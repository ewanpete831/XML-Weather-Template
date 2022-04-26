using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();
        public static string location = "Stratford, CA";


        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            GetConditions();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            //get weather data
            days.Clear();
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={location}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //main forcast data
                Day newDay = new Day();

                reader.ReadToFollowing("time");
                newDay.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                newDay.icon = reader.GetAttribute("var");

                reader.ReadToFollowing("temperature");
                newDay.tempLow = reader.GetAttribute("min");
                newDay.tempHigh = reader.GetAttribute("max");

                if (newDay.date != null)
                {
                    days.Add(newDay);
                }
            }
            reader.Close();
        }

        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={location}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].icon = reader.GetAttribute("icon");
        }

        public static void GetConditions() // use the weather condition codes to simplify descriptions, set correct icons
        {
            foreach(Day d in days)
            {
                if (d.icon.Contains("01"))
                {
                    d.condition = "Clear Sky";
                    d.bgImage = Properties.Resources.clear;
                }
                else if (d.icon.Contains("02"))
                {
                    d.condition = "Few Clouds";
                    d.bgImage = Properties.Resources.cloud;
                }
                else if (d.icon.Contains("03") || d.icon.Contains("04"))
                {
                    d.condition = "Cloudy";
                    d.bgImage = Properties.Resources.cloud;
                }
                else if (d.icon.Contains("09") || d.icon.Contains("10"))
                {
                    d.condition = "Rain";
                    d.bgImage = Properties.Resources.rain;
                }
                else if (d.icon.Contains("11"))
                {
                    d.condition = "Thunderstorm";
                    d.bgImage = Properties.Resources.rain;
                }
                else if (d.icon.Contains("13"))
                {
                    d.condition = "Snow";
                    d.bgImage = Properties.Resources.snow;
                }
                else if (d.icon.Contains("50"))
                {
                    d.condition = "Mist";
                    d.bgImage = Properties.Resources.cloud;
                }
            }
        }
    }
}
