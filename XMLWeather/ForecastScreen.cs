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
            BackgroundImage = Form1.days[0].bgImage;

            max1.Parent = min1.Parent = icon1.Parent = date1.Parent = backLabel1;
            backLabel1.Image = Form1.days[1].bgImage;
            date1.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            double minTemp = Convert.ToDouble(Form1.days[1].tempLow);
            double maxTemp = Convert.ToDouble(Form1.days[1].tempHigh);
            min1.Text = Math.Round(minTemp).ToString();
            max1.Text = Math.Round(maxTemp).ToString();
            icon1.ImageLocation = $"http://openweathermap.org/img/wn/{Form1.days[1].icon}@2x.png";

            date2.Parent = icon2.Parent = max2.Parent = min2.Parent = backLabel2;
            backLabel2.Image = Form1.days[2].bgImage;
            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            minTemp = Convert.ToDouble(Form1.days[2].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[2].tempHigh);
            min2.Text = Math.Round(minTemp).ToString();
            max2.Text = Math.Round(maxTemp).ToString();
            icon2.ImageLocation = $"http://openweathermap.org/img/wn/{Form1.days[2].icon}@2x.png";

            date3.Parent = icon3.Parent = max3.Parent = min3.Parent = backLabel3;
            backLabel3.Image = Form1.days[3].bgImage;
            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            minTemp = Convert.ToDouble(Form1.days[3].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[3].tempHigh);
            min3.Text = Math.Round(minTemp).ToString();
            max3.Text = Math.Round(maxTemp).ToString();
            icon3.ImageLocation = $"http://openweathermap.org/img/wn/{Form1.days[3].icon}@2x.png";

            date4.Parent = icon4.Parent = max4.Parent = min4.Parent = backLabel4;
            backLabel4.Image = Form1.days[4].bgImage;
            date4.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            minTemp = Convert.ToDouble(Form1.days[4].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[4].tempHigh);
            min4.Text = Math.Round(minTemp).ToString();
            max4.Text = Math.Round(maxTemp).ToString();
            icon4.ImageLocation = $"http://openweathermap.org/img/wn/{Form1.days[4].icon}@2x.png";

            date5.Parent = icon5.Parent = max5.Parent = min5.Parent = backLabel5;
            backLabel5.Image = Form1.days[5].bgImage;
            date5.Text = DateTime.Now.AddDays(5).DayOfWeek.ToString();
            minTemp = Convert.ToDouble(Form1.days[5].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[5].tempHigh);
            min5.Text = Math.Round(minTemp).ToString();
            max5.Text = Math.Round(maxTemp).ToString();
            icon5.ImageLocation = $"http://openweathermap.org/img/wn/{Form1.days[5].icon}@2x.png";
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
