using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            double minTemp = Convert.ToDouble(Form1.days[1].tempLow);
            double maxTemp = Convert.ToDouble(Form1.days[1].tempHigh);
            min1.Text = Math.Round(minTemp).ToString();
            max1.Text = Math.Round(maxTemp).ToString();
            switch (Form1.days[1].condition)
            {

            }

            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            minTemp = Convert.ToDouble(Form1.days[2].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[2].tempHigh);
            min2.Text = Math.Round(minTemp).ToString();
            max2.Text = Math.Round(maxTemp).ToString();

            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            minTemp = Convert.ToDouble(Form1.days[3].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[3].tempHigh);
            min3.Text = Math.Round(minTemp).ToString();
            max3.Text = Math.Round(maxTemp).ToString();

            date4.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            minTemp = Convert.ToDouble(Form1.days[4].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[4].tempHigh);
            min4.Text = Math.Round(minTemp).ToString();
            max4.Text = Math.Round(maxTemp).ToString();

            date5.Text = DateTime.Now.AddDays(5).DayOfWeek.ToString();
            minTemp = Convert.ToDouble(Form1.days[5].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[5].tempHigh);
            min5.Text = Math.Round(minTemp).ToString();
            max5.Text = Math.Round(maxTemp).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
    }
}
