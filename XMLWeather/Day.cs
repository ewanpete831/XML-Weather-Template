using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

//day class
namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, visibility, icon;

        public Image bgImage;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = icon = "";
        }
    }
}
