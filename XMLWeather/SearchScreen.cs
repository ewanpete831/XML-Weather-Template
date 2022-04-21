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
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.location = searchBox.Text;

                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                Form f = this.FindForm();
                f.Controls.Remove(this);

                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
            catch
            {
                errorLabel.Visible = true;
                searchBox.Clear();
                Refresh();
                Thread.Sleep(2000);
                errorLabel.Visible = false;
            }
        }
    }
}
