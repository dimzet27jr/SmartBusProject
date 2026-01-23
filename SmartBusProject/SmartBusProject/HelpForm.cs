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
    public partial class HelpForm : Form
    {
        private Dictionary<string, string> helpTexts;
        public HelpForm()
        {
            InitializeComponent();
            LoadHelpTexts();
            AddTexts();
        }

        private void LoadHelpTexts()
        {
            helpTexts = new Dictionary<string, string>();

            helpTexts["Γενική Πλοήγηση"] = @"
             Γενική Πλοήγηση
             Η εφαρμογή περιλαμβάνει ξεχωριστές φόρμες για:
             -Επιβάτες
             -Οδηγούς
            ";
        }

        private void AddTexts()
        {
            HelpListBox.Items.Clear();

            foreach (var text in helpTexts.Keys) 
            {
                HelpListBox.Items.Add(text);
            }

            if(HelpListBox.Items.Count > 0)
            {
                HelpListBox.SelectedIndex = 0;
            }
        }

        private void ChangeIndex(object sender, EventArgs e)
        {
            if (HelpListBox.SelectedIndex == null) return;

            string index = HelpListBox.SelectedIndex.ToString();

            if (helpTexts.ContainsKey(index))
            {
                HelpTextBox.Text = helpTexts[index];
            }
        }
    }
}
