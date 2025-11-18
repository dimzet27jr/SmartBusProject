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
        private int rows = 4;
        private int cols = 2;
        private int floors = 3;
        private int seatsPerFloor => rows * cols;

        private Dictionary<int, Button> seatButtons = new Dictionary<int, Button>();
        private HashSet<int> selectedZones = new HashSet<int>();
        private List<EventRecord> events = new List<EventRecord>();
        private Random rnd = new Random();

        private int cleaningTotalTicks = 0;
        private int cleaningTick = 0;
        private int currentCleaningZone = -1;
        private bool isPaused = false;

        public VacuumForm()
        {
            InitializeComponent();
            CreateSeatButtonsForAllFloors();
            LoadFloorSeats(0);
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
                    b.Size = new Size(90, 48);
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

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    int local = r * cols + c;
                    int globalIndex = floorIndex * seatsPerFloor + local;
                    if (seatButtons.TryGetValue(globalIndex, out var btn))
                    {
                        var tag = (SeatTag)btn.Tag;
                        btn.Text = $"F{tag.Floor} - {tag.LocalIndex + 1}";
                        btn.Font = new Font(btn.Font.FontFamily, 9, FontStyle.Regular);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        ZonesPanels.Controls.Add(btn);
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

        private void StartCleaningSeat(int globalIndex)
        {
            currentCleaningZone = globalIndex;
            cleaningTick = 0;

            int baseSeconds = ModesSelections.SelectedItem != null ? GetBaseDurationForMode(ModesSelections.SelectedItem.ToString()) : 12;
            var btn = seatButtons[globalIndex];
            baseSeconds += btn.BackColor == Color.IndianRed ? 5 : 0;

            cleaningTotalTicks = Math.Max(1, (int)Math.Ceiling(baseSeconds / (cleaningTimer.Interval / 1000.0)));
            CleaningProssess.Maximum = cleaningTotalTicks;
            CleaningProssess.Value = 0;

            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            btnHistory.Enabled = false;

            MessageBox.Show($"Η σκούπα ξεκινάει καθαρισμό: Όροφος {((SeatTag)btn.Tag).Floor}, Θέση {((SeatTag)btn.Tag).LocalIndex + 1}", "Ξεκινάει Καθαρισμός", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StatusLabel.Text = $"Status: Cleaning floor {((SeatTag)btn.Tag).Floor} seat {((SeatTag)btn.Tag).LocalIndex + 1}";
            cleaningTimer.Start();
        }

        private int GetBaseDurationForMode(string mode)
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
                CompleteCleaningCurrent();
            }
        }

        private void CompleteCleaningCurrent()
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
            btnHistory.Enabled = true;
            StatusLabel.Text = "Status: Idle";

            var queueObj = this.Tag as List<int>;
            if (queueObj != null && queueObj.Any())
            {
                int next = queueObj.First();
                queueObj.RemoveAt(0);
                this.Tag = queueObj; 
                Application.DoEvents();
                StartCleaningSeat(next);
            }
        }

        private (string Item, string Importance)? MaybeDetectItem()
        {
            double p = rnd.NextDouble();
            if (p < 0.55) return null; // 55% πιθανότητα τίποτα

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


        private class SeatTag
        {
            public int Floor;
            public int LocalIndex;
            public int GlobalIndex;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
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

            this.Tag = queue.Skip(1).ToList();
            StartCleaningSeat(queue.First());
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

            // αφήνουμε τη θέση ως βρώμικη (δεν αλλάζουμε χρώμα)
            var tag = (SeatTag)seatButtons[currentCleaningZone].Tag;
            MessageBox.Show($"Ο καθαρισμός ακυρώθηκε: Όροφος {tag.Floor}, Θέση {tag.LocalIndex + 1}", "Stopped", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            currentCleaningZone = -1;
            CleaningProssess.Value = 0;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnHistory.Enabled = true;
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
            btnHistory.Enabled = true;
            StatusLabel.Text = "Status: Emergency Stop activated!";
            MessageBox.Show("EMERGENCY STOP: Η λειτουργία της σκούπας διακόπηκε άμεσα.", "EMERGENCY", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (!events.Any())
            {
                MessageBox.Show("Δεν υπάρχουν εγγεγραμμένα ευρήματα.", "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
