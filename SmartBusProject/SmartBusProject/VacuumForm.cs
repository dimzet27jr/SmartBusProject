using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SmartBusProject
{
    public partial class VacuumForm : Form
    {
        private int rows = 5;
        private int cols = 2;
        private int floors = 3;
        private int seatsPerFloor => rows * cols;

        private Dictionary<int, Button> seatButtons = new Dictionary<int, Button>();
        private HashSet<int> selectedZones = new HashSet<int>();
        private List<EventRecord> events = new List<EventRecord>();
        private Random rnd = new Random();
        private List<int> pendingQueue = null;

        private int cleaningTotalTicks = 0;
        private int cleaningTick = 0;
        private int currentCleaningZone = -1;
        private bool isPaused = false;

        private int displayRows = 2;
        private int chargeStepPercent = 5;

        public VacuumForm()
        {
            InitializeComponent();
            CreateSeatButtonsForAllFloors();
            FloorSelector.SelectedIndexChanged -= FloorSelector_SelectedIndexChanged;
            FloorSelector.SelectedIndexChanged += FloorSelector_SelectedIndexChanged;
            FloorSelector.SelectedIndex = 0;
        }

        private void CreateSeatButtonsForAllFloors()
        {
            seatButtons.Clear();

            for (int f = 0; f < floors; f++)
            {
                for (int i = 0; i < seatsPerFloor; i++)
                {
                    int globalIndex = f * seatsPerFloor + i;
                    Button b = new Button();
                    b.Size = new Size(90, 40);
                    b.Text = $"S{i + 1}";
                    b.Tag = new SeatTag { Floor = f, LocalIndex = i, GlobalIndex = globalIndex };
                    b.BackColor = RandomDirtyColor();
                    b.ForeColor = Color.White;
                    b.Margin = new Padding(6);
                    b.Click += SeatButton_Click;
                    seatButtons[globalIndex] = b;
                }
            }
        }

        private Color RandomDirtyColor()
        {
            return rnd.NextDouble() < 0.6 ? Color.IndianRed : Color.SeaGreen;
        }

        private void LoadFloorSeats(int floorIndex)
        {
            ZonesPanels.Controls.Clear();
            selectedZones.Clear();

            int total = seatsPerFloor;
            int perRow = Math.Max(1, (int)Math.Ceiling(total / (double)displayRows));

            int counter = 0;

            for (int local = 0; local < seatsPerFloor; local++)
            {
                int globalIndex = floorIndex * seatsPerFloor + local;
                if (seatButtons.TryGetValue(globalIndex, out var btn))
                {
                    btn.Text = $"F{floorIndex} - {((SeatTag)btn.Tag).LocalIndex + 1}";
                    btn.Font = new Font(btn.Font.FontFamily, 9, FontStyle.Regular);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    ZonesPanels.Controls.Add(btn);
                    counter++;
                    if (counter % perRow == 0)
                    {
                        ZonesPanels.SetFlowBreak(btn, true);
                    }
                    else
                    {
                        ZonesPanels.SetFlowBreak(btn, false);
                    }
                }
            }

            StatusLabel.Text = $"Status: Loaded floor {floorIndex}";
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            var tag = (SeatTag)b.Tag;
            int globalIndex = tag.GlobalIndex;

            if (b.BackColor.ToArgb() == Color.SeaGreen.ToArgb())
            {
                MessageBox.Show("Αυτή η θέση είναι ήδη καθαρή.", "Already Clean", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selectedZones.Contains(globalIndex))
            {
                selectedZones.Remove(globalIndex);
                b.Font = new Font(b.Font, FontStyle.Regular);
                b.FlatAppearance.BorderColor = SystemColors.Control;
                b.FlatAppearance.BorderSize = 0;
            }
            else
            {
                selectedZones.Add(globalIndex);
                b.Font = new Font(b.Font, FontStyle.Bold);
                b.FlatAppearance.BorderColor = Color.Black;
                b.FlatAppearance.BorderSize = 1;
            }

            StatusLabel.Text = $"Status: {selectedZones.Count} zone(s) selected on floor {tag.Floor}";
        }

        private void StartCleaning(int globalIndex)
        {
            if (BatteryLife.Value > 0)
            {
                currentCleaningZone = globalIndex;
                cleaningTick = 0;

                int baseSeconds = ModesSelections.SelectedItem != null ? VacuumModesTimes(ModesSelections.SelectedItem.ToString()) : 12;
                var btn = seatButtons[globalIndex];
                baseSeconds += btn.BackColor == Color.IndianRed ? 5 : 0;

                cleaningTotalTicks = Math.Max(1, (int)Math.Ceiling(baseSeconds / (cleaningTimer.Interval / 1000.0)));
                CleaningProssess.Maximum = cleaningTotalTicks;
                CleaningProssess.Value = 0;

                btnPause.Enabled = true;
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                btnCharge.Enabled = false;

                MessageBox.Show($"Η σκούπα ξεκινάει καθαρισμό: Όροφος {((SeatTag)btn.Tag).Floor}, Θέση {((SeatTag)btn.Tag).LocalIndex + 1}", "Ξεκινάει Καθαρισμός", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StatusLabel.Text = $"Status: Cleaning floor {((SeatTag)btn.Tag).Floor} seat {((SeatTag)btn.Tag).LocalIndex + 1}";
                cleaningTimer.Start();
            }
            else
            {
                MessageBox.Show("Η σκούπα δεν έχει μπαταρία. Ο καθαρισμός δεν μπορεί να ξεκινήσει.", "Empty Battery", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private int VacuumModesTimes(string mode)
        {
            switch (mode.ToLower())
            {
                case "spot": return 8;
                case "edge": return 10;
                case "quick": return 6;
                case "deep": return 18;
                case "auto": default: return 12;
            }
        }

        private void CleaningTimer_Tick(object sender, EventArgs e)
        {
            if (isPaused || currentCleaningZone == -1) return;

            cleaningTick++;
            CleaningProssess.Value = Math.Min(CleaningProssess.Maximum, cleaningTick);

            if (BatteryLife.Value > 0 && cleaningTick % 2 == 0)
            {
                BatteryLife.Value = Math.Max(0, BatteryLife.Value - 1);
                BatteryPersent.Text = $"{BatteryLife.Value}%";
            }

            if (cleaningTick >= cleaningTotalTicks)
            {
                cleaningTimer.Stop();
                CompleteCleaning();
            }
        }

        private void CompleteCleaning()
        {
            if (currentCleaningZone == -1) return;

            var btn = seatButtons[currentCleaningZone];
            var tag = (SeatTag)btn.Tag;

            var found = MaybeDetectItem();

            if (found != null && (found.Value.Importance == "high" || found.Value.Importance == "medium"))
            {
                EventRecord record = new EventRecord(DateTime.Now, tag.Floor, tag.LocalIndex + 1, found.Value.Item, found.Value.Importance);
                events.Add(record);
                AddEventToListView(record);
            }


            btn.BackColor = Color.SeaGreen;
            btn.Font = new Font(btn.Font, FontStyle.Regular);

            string foundText = found == null ? "Τίποτα" : $"{found.Value.Item} ({found.Value.Importance})";
            MessageBox.Show($"Ολοκληρώθηκε ο καθαρισμός: Όροφος {tag.Floor}, Θέση {tag.LocalIndex + 1}\nΕύρημα: {foundText}", "Ολοκληρώθηκε", MessageBoxButtons.OK, MessageBoxIcon.Information);

            currentCleaningZone = -1;
            CleaningProssess.Value = 0;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnCharge.Enabled = true;
            StatusLabel.Text = "Status: Idle";

            if (pendingQueue != null && pendingQueue.Any())
            {
                int next = pendingQueue.First();
                pendingQueue.RemoveAt(0);
                Application.DoEvents();
                StartCleaning(next);
            }
            else
            {
                pendingQueue = null;
            }
        }

        private (string Item, string Importance)? MaybeDetectItem()
        {
            double p = rnd.NextDouble();
            if (p < 0.30) return null;

            string[] items = new[] { "Κέρματα", "Κλειδιά", "Διαβατήριο", "Κόσμημα", "Απόδειξη", "Χαρτονόμισμα" };
            string item = items[rnd.Next(items.Length)];
            string importance;
            if (item == "Διαβατήριο" || item == "Κόσμημα" || item == "Χαρτονόμισμα")
                importance = "high";
            else if (item == "Κλειδιά")
                importance = "medium";
            else
                importance = "low";

            return (item, importance);
        }

        private void AddEventToListView(EventRecord rec)
        {
            var eventList = new ListViewItem(rec.Time.ToString("g"));
            eventList.SubItems.Add($"Floor {rec.Floor}");
            eventList.SubItems.Add($"Seat {rec.SeatNumber}");
            eventList.SubItems.Add($"{rec.Item}");
            eventList.SubItems.Add($"{rec.Importance}");
            EventList.Items.Add(eventList);
        }

        private void FloorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = FloorSelector.SelectedIndex;
            if (idx >= 0)
            {
                LoadFloorSeats(idx);
            }
        }
        private class SeatTag
        {
            public int Floor;
            public int LocalIndex;
            public int GlobalIndex;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (FloorSelector.SelectedIndex < 0)
            {
                MessageBox.Show("Επίλεξε πρώτα τον όροφο καθαρισμού.", "Missing Floor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ModesSelections.SelectedIndex < 0)
            {
                MessageBox.Show("Επίλεξε τύπο λειτουργίας της σκούπας (Cleaning Mode).", "Missing Mode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentCleaningZone != -1)
            {
                MessageBox.Show("Υπάρχει ενεργός καθαρισμός αυτή τη στιγμή. Σταμάτησέ τον ή περίμενε να τελειώσει.", "Busy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!selectedZones.Any())
            {
                MessageBox.Show("Επίλεξε μία ή περισσότερες θέσεις για καθαρισμό (κάνε κλικ πάνω στις θέσεις).", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var queue = selectedZones.ToList();
            selectedZones.Clear();

            pendingQueue = queue.Skip(1).ToList();
            StartCleaning(queue.First());
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            if (currentCleaningZone == -1) return;

            if (!isPaused)
            {
                cleaningTimer.Stop();
                isPaused = true;
                btnPause.Text = "Resume";
                StatusLabel.Text = "Status: Paused";
            }
            else
            {
                cleaningTimer.Start();
                isPaused = false;
                btnPause.Text = "Pause";
                var tag = (SeatTag)seatButtons[currentCleaningZone].Tag;
                StatusLabel.Text = $"Status: Cleaning floor {tag.Floor} seat {tag.LocalIndex + 1}";
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (currentCleaningZone == -1) return;

            cleaningTimer.Stop();
            isPaused = false;

            var tag = (SeatTag)seatButtons[currentCleaningZone].Tag;
            MessageBox.Show($"Ο καθαρισμός ακυρώθηκε: Όροφος {tag.Floor}, Θέση {tag.LocalIndex + 1}", "Stopped", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            currentCleaningZone = -1;
            CleaningProssess.Value = 0;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnCharge.Enabled = true;
            StatusLabel.Text = "Status: Idle (stopped)";
        }

        private void btnEmergency_Click_1(object sender, EventArgs e)
        {
            if (currentCleaningZone != -1)
            {
                cleaningTimer.Stop();
            }
            isPaused = false;
            currentCleaningZone = -1;
            CleaningProssess.Value = 0;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnCharge.Enabled = true;
            StatusLabel.Text = "Status: Emergency Stop activated!";
            MessageBox.Show("EMERGENCY STOP: Η λειτουργία της σκούπας διακόπηκε άμεσα.", "EMERGENCY", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            if (chargeTimer.Enabled)
            {
                MessageBox.Show("Η φόρτιση είναι ήδη σε εξέλιξη.", "Charging", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnStart.Enabled = false;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnEmergency.Enabled = false;
            btnCharge.Enabled = false;

            StatusLabel.Text = "Status: Charging...";
            chargeTimer.Start();
        }
        private void ChargeTimer_Tick(object sender, EventArgs e)
        {
            int newVal = Math.Min(100, BatteryLife.Value + chargeStepPercent);
            BatteryLife.Value = newVal;
            BatteryPersent.Text = $"{BatteryLife.Value}%";

            if (BatteryLife.Value >= 100)
            {
                chargeTimer.Stop();
                StatusLabel.Text = "Status: Idle";
                MessageBox.Show("Η μπαταρία επαναφορτίστηκε στο 100%.", "Charged", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnStart.Enabled = true;
                btnPause.Enabled = false;
                btnStop.Enabled = false;
                btnEmergency.Enabled = true;
                btnCharge.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new DriverMainForm().Show();
            this.Close();
        }
    }
}