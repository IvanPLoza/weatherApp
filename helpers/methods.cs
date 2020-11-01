using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.helpers
{
    public class Helpers
    {
        public static string getTemperatureDisplayValueFromString(string val)
        {
            if (val != null)
            {
                return Convert.ToString(Math.Round(Convert.ToDouble(val))) + "°";
            }
            else
            {
                return "Ne";
            }
        }

        public static string getHumidtyDisplayValueFromString(string val)
        {
            if (val != null)
            {
                return val + "%";
            }
            else
            {
                return "Ne";
            }
        }

        public static string getWindDisplayValuesFromString(string speed, string deg)
        {
            if(speed != null && deg != null)
            {
                return speed + "kmh/" + deg + "°";
            }
            else
            {
                return "Ne";
            }
        }

        public static string getVisibilityDisplayValuesFromString(string val)
        {
            if (val != null)
            {
                return val + "%";
            }
            else
            {
                return "Ne";
            }
        }
    }
}
