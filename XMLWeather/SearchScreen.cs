using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        string lastLocation;

        public SearchScreen()
        {
            InitializeComponent();
            BackgroundImage = Form1.days[0].bgImage;
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            try
            {
                lastLocation = Form1.location;
                Form1.location = searchBox.Text;

                Form1.ExtractForecast();
                Form1.ExtractCurrent();
                Form1.GetConditions();

                Form f = this.FindForm();
                f.Controls.Remove(this);

                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
            catch
            {
                Form1.location = lastLocation;
                errorLabel.Visible = true;
                searchBox.Clear();
                Refresh();
                Thread.Sleep(2000);
                errorLabel.Visible = false;
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1.ExtractForecast();
            Form1.ExtractCurrent();
            Form1.GetConditions();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
