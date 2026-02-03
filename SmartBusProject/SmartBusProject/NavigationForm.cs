using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBusProject
{
    public partial class NavigationForm : Form
    {
        private Form parentForm;
        private List<PictureBox> restaurantPictureBoxes;
        private Dictionary<BusStops, List<PictureBox>> stopRestaurantsMap;
        private Dictionary<BusStops, PictureBox> stopLandmarkMap;
        private Dictionary<Restaurants, PictureBox> restaurantPathMap;
        private PictureBox activePath = null;
        private PictureBox selectedBusStop = null;
        public NavigationForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            restaurantPictureBoxes = new List<PictureBox> { tavernaNikos, souvlakiExpress, mparmpalias, toStekiTouToManoli, tavernaThea, bistroBar, acropolisUpperView, toPioLambroMpouzouki, tavernThemistikles };
            stopRestaurantsMap = new Dictionary<BusStops, List<PictureBox>>();
            stopLandmarkMap = new Dictionary<BusStops, PictureBox>();
            restaurantPathMap = new Dictionary<Restaurants, PictureBox>();
            SetTagToBusStops();
            SetPathToRestaurants();
        }

        private void SetTagToBusStops()
        {
            busStopThesio.Tag = Program.busStops[0];
            busStopPnika.Tag = Program.busStops[1];
            busStopHrodio.Tag = Program.busStops[2];
            busStopAcropolis.Tag = Program.busStops[3];

            stopRestaurantsMap[Program.busStops[0]] = new List<PictureBox> { tavernaNikos, souvlakiExpress, mparmpalias, toStekiTouToManoli };
            stopRestaurantsMap[Program.busStops[1]] = new List<PictureBox> { tavernaThea, bistroBar };
            stopRestaurantsMap[Program.busStops[2]] = new List<PictureBox> { acropolisUpperView };
            stopRestaurantsMap[Program.busStops[3]] = new List<PictureBox> { toPioLambroMpouzouki, tavernThemistikles };

            stopLandmarkMap[Program.busStops[0]] = thesio_location;
            stopLandmarkMap[Program.busStops[1]] = pnika_location;
            stopLandmarkMap[Program.busStops[2]] = hrodio_locaton;
            stopLandmarkMap[Program.busStops[3]] = acropoli_location;
        }

        private void SetPathToRestaurants()
        {
            foreach (var stop in Program.busStops)
            {
                foreach (var restaurant in stop.Restaurants)
                {
                    if (restaurant.name == "Ταβέρνα ο Νίκος")
                    {
                        restaurantPathMap[restaurant] = tavernaNikos_path;
                    }
                    else if (restaurant.name == "Σουβλάκι Express")
                    {
                        restaurantPathMap[restaurant] = souvlakiExpress_path;
                    }
                    else if (restaurant.name == "Μπαρμπαλιάς")
                    {
                        restaurantPathMap[restaurant] = mparmpalias_path;
                    }
                    else if (restaurant.name == "Το στέκι του Μανώλη")
                    {
                        restaurantPathMap[restaurant] = toStekiTouManoli_path;
                    }
                    else if (restaurant.name == "Ταβέρνα 'Η θέα'")
                    {
                        restaurantPathMap[restaurant] = tavernaThea_path;
                    }
                    else if (restaurant.name == "Bistro Bar")
                    {
                        restaurantPathMap[restaurant] = bistrobar_path;
                    }
                    else if (restaurant.name == "Acropolis Upper View")
                    {
                        restaurantPathMap[restaurant] = acropolisUpperView_path;
                    }
                    else if (restaurant.name == "Ουζερί 'Το πιο λαμπρό μπουζούκι'")
                    {
                        restaurantPathMap[restaurant] = toPioLamproMpouzouki_path;
                    }
                    else if (restaurant.name == "Ταβέρνα 'Ο Θεμιστοκλής'")
                    {
                        restaurantPathMap[restaurant] = tavernaThemistokles_path;
                    }
                }
            }
        }

        private void BusStop_Click(object sender, EventArgs e)
        {
            var rest = sender as PictureBox;
            var busStop = rest.Tag as BusStops;

            if (activePath != null)
            {
                activePath.Visible = false;
                activePath = null;
            }

            if (busStop == null) return;

            toolTip1.RemoveAll();

            if (selectedBusStop != null)
            {
                selectedBusStop.BackgroundImage = Properties.Resources.bus_stop;
            }

            selectedBusStop = rest;
            rest.BackgroundImage = Properties.Resources.bus_stop_selected;

            ShowRestaurantsForStop(busStop);
            ShowWanderForStop(busStop);
        }

        private void ShowRestaurantsForStop(BusStops stop)
        {
            foreach (var pbx in restaurantPictureBoxes)
            {
                pbx.Visible = false;
                pbx.Tag = null;
            }

            if (!stopRestaurantsMap.ContainsKey(stop))
                return;

            var pbs = stopRestaurantsMap[stop];

            for (int i = 0; i < stop.Restaurants.Count; i++)
            {
                var pbxRest = pbs[i];
                var restaurant = stop.Restaurants[i];

                pbxRest.Tag = restaurant;
                pbxRest.Visible = true;
                pbxRest.Cursor = Cursors.Hand;

                pbxRest.MouseHover -= Restaurant_MouseHover;
                pbxRest.MouseHover += Restaurant_MouseHover;
            }

        }

        private void ShowWanderForStop(BusStops stop)
        {
            foreach (var wander in stopLandmarkMap.Values)
            {
                wander.Visible = false;
            }

            if (stopLandmarkMap.ContainsKey(stop))
            {
                var pbxWander = stopLandmarkMap[stop];
                pbxWander.Visible = true;
            }
        }
        private void Restaurant_MouseHover(object sender, EventArgs e)
        {
            var pbx = sender as PictureBox;
            var restaurant = pbx.Tag as Restaurants;

            if (restaurant == null) return;

            toolTip1.SetToolTip(pbx, $"{restaurant.name}\n{restaurant.address}\n{restaurant.distance}");
        }

        private void Restaurant_Click(object sender, EventArgs e)
        {
            var pbxRestaurant = sender as PictureBox;
            var restaurant = pbxRestaurant?.Tag as Restaurants;
            if (restaurant == null) return;

            if (activePath != null)
                activePath.Visible = false;

            if (!restaurantPathMap.ContainsKey(restaurant))
                return;

            activePath = restaurantPathMap[restaurant];
            activePath.Visible = true;
        }

        private void acropoli_location_Click(object sender, EventArgs e)
        {
            var wander = new Wander(Program.Acropoli, Program.Acropoli_Desc, Properties.Resources.ancient_acropoli, Properties.Resources.acropoli_map);
            new WanderViewForm(wander).Show();
            this.Hide();
        }

        private void hrodio_locaton_Click(object sender, EventArgs e)
        {
            var wander = new Wander(Program.Hrodio, Program.Hrodio_Desc, Properties.Resources.hrodio, Properties.Resources.hrodio_map);
            new WanderViewForm(wander).Show();
            this.Hide();
        }

        private void pnika_location_Click(object sender, EventArgs e)
        {
            var wander = new Wander(Program.Ethniko_Mouseio, Program.Ethniko_Mouseio_Desc, Properties.Resources.pnika, Properties.Resources.pnika_map);
            new WanderViewForm(wander).Show();
            this.Hide();
        }

        private void thesio_location_Click(object sender, EventArgs e)
        {
            var wander = new Wander(Program.Theseio, Program.Theseio_Desc, Properties.Resources.theseio, Properties.Resources.theseio_map);
            new WanderViewForm(wander).Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new PassengersMainForm().Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new NavigatonInfo().Show();
        }

        private void NavigationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

    }
}
