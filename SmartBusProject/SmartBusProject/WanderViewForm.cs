using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SmartBusProject
{
    public partial class WanderViewForm : Form
    {
        private Wander wander;
        private SpeechSynthesizer speaker;

        public WanderViewForm(Wander wander)
        {
            InitializeComponent();
            this.wander = wander;

            speaker = new SpeechSynthesizer();
            speaker.SetOutputToDefaultAudioDevice();
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("el-GR"));

            LoadWanderData();
        }

        private void LoadWanderData()
        {
            Text = wander.Title;
            BackgroundImage = Properties.Resources.wander_background;
            WanderTitle.Text = wander.Title;
            pbxWander.BackgroundImage = wander.photo;
            pbxMap.BackgroundImage = wander.map;
            Wander_Desc.Text = wander.Description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            speaker.SpeakAsyncCancelAll();
            this.Close();
            new PassengerWandersForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            speaker.SpeakAsyncCancelAll();
            Application.Exit();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            speaker.SpeakAsyncCancelAll();
            speaker.SpeakAsync(wander.Description);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            speaker.SpeakAsyncCancelAll();
        }

        private void pbxMap_Click(object sender, EventArgs e)
        {
            speaker.SpeakAsyncCancelAll();
            new NavigationForm().Show();
            this.Close();
        }
    }
}
