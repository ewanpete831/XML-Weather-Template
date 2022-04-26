﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //show important information on screen
            double currentTemp = Convert.ToDouble(Form1.days[0].currentTemp);
            double temp = Math.Round(currentTemp);

            double maxTemp = Convert.ToDouble(Form1.days[0].tempHigh);
            double max = Math.Round(maxTemp);

            double minTemp = Convert.ToDouble(Form1.days[0].tempLow);
            double min = Math.Round(minTemp);

            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = $"{temp.ToString()}°";
            minOutput.Text = $"{min.ToString()}°";
            maxOutput.Text = $"{max.ToString()}°";
            contitionLabel.Text = Form1.days[0].condition;
            dateLabel.Text = DateTime.Now.DayOfWeek.ToString();

            //get images
            weatherIconBox.ImageLocation = $"http://openweathermap.org/img/wn/{Form1.days[0].icon}@2x.png";

            BackgroundImage = Form1.days[0].bgImage;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //change to forecast screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //change to search screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
    }
}
