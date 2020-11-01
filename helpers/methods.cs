using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Text;
using WeatherApp.requests;

namespace WeatherApp.helpers
{
    public class Helpers
    {
        public class DailyWeather
        {
            public string temp { get; set; }

            public string title { get; set; }

            public string humidity { get; set; }

            public string windSpeed { get; set; }

            public string windDegree { get; set; }

            public string visibility { get; set; }

            public DateTime date { get; set; }
        }

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

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static string[] getFutureWeatherHourlyDisplayValues(IList <ListW> weathers, Int32 count)
        {
            string[] ret = new string[count];

            for(int i = 0; i < count; i++)
            {
                ret[i] = UnixTimeStampToDateTime(   weathers[i].dt).ToString("hh:mm") +
                                                    " " +
                                                    getTemperatureDisplayValueFromString(weathers[i].main.temp_min) +
                                                    "/" +
                                                    getTemperatureDisplayValueFromString(weathers[i].main.temp_max);
            }

            return ret;
        }

        public static string getFutureDailyWeatherDay(DailyWeather weather)
        {
            return weather.date.DayOfWeek + " " + weather.title;
        }

        public static string getFutureDailyWeatherTemperature(DailyWeather weather)
        {
            return getTemperatureDisplayValueFromString(weather.temp);
        }

        public static string getFutureDailyWeatherHumidty(DailyWeather weather)
        {
            return getHumidtyDisplayValueFromString(weather.humidity);
        }

        public static string getFutureDailyWeatherVisiblity(DailyWeather weather)
        {
            return getVisibilityDisplayValuesFromString(weather.visibility);
        }

        public static DailyWeather[] getFutureDailyWeatherList(IList <ListW> weathers, int count)
        {
            DailyWeather[] weather = new DailyWeather[count];

            for (int i = 0; i < count; i++)
            {

                DailyWeather weatherDay = new DailyWeather();

                weatherDay.date = UnixTimeStampToDateTime(weathers[i].dt);
                weatherDay.temp = weathers[i].main.temp;
                weatherDay.humidity = weathers[i].main.humidity;
                weatherDay.title = weathers[i].weather[0].main;
                weatherDay.visibility = weathers[i].visibility;
                weatherDay.windSpeed = weathers[i].wind.speed;
                weatherDay.windDegree = weathers[i].wind.deg;

                weather[i] = weatherDay;
                
            }

            return weather;
        }
    }
}
