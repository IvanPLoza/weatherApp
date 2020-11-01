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
            public string tempMin { get; set; }

            public string tempMax { get; set; }

            public string title { get; set; }

            public string humidity { get; set; }

            public string windSpeed { get; set; }

            public string windDegree { get; set; }

            public string visibility { get; set; }

            public DateTime date { get; set; }
        }
        public static string roundMinMaxTemperature(string min, string max)
        {
            return Convert.ToString((Convert.ToDouble(min) + Convert.ToDouble(max)) / 2.00);
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
                return val + "m";
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

        public static string[] getFutureDailyWeatherDisplayValues(DailyWeather[] weathers, string type)
        {
            string[] ret = new string[weathers.Length];

            switch (type)
            {
                case "day":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = weathers[i].date.DayOfWeek + "/" + weathers[i].title;
                    }
                    return ret;
                

                case "temp":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = getFutureDailyWeatherTemperature(weathers[i].tempMin, weathers[i].tempMax);
                    }
                break;

                case "vis":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = getVisibilityDisplayValuesFromString(weathers[i].visibility);
                    }
                    return ret;
                

                case "hum":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = getHumidtyDisplayValueFromString(weathers[i].humidity);
                    }
                    return ret;

                case "wind":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = getWindDisplayValuesFromString(weathers[i].windSpeed, weathers[i].windDegree);
                    }
                    return ret;
            }

            return ret;
        }
        public static string[] getFutureDailyWeatherTemperatureDisplayValues(DailyWeather[] weathers)
        {
            string[] ret = new string[weathers.Length];

            for (int i = 0; i < weathers.Length; i++)
            {
                ret[i] = weathers[i].date.DayOfWeek + "/" + weathers[i].title;
            }
            return ret;
        }


        public static string getFutureDailyWeatherTemperature(string min, string max)
        {
            return getTemperatureDisplayValueFromString(min) + "/" + getTemperatureDisplayValueFromString(max);
        }

        public static string getIconUrl(string icon)
        {
            return "http://openweathermap.org/img/wn/" + icon + "@2x.png";
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
            DailyWeather[] weather = new DailyWeather[5];
            int dayCounter = DateTime.Now.Day;
            int today = dayCounter;

            for (int i = 0; i < count; i++)
            {
                DateTime date = UnixTimeStampToDateTime(weathers[i].dt);
            
                if (date.Day > dayCounter)
                {
                    DailyWeather weatherDay = new DailyWeather();

                    weatherDay.date = UnixTimeStampToDateTime(weathers[i].dt);
                    weatherDay.tempMin = weathers[i].main.temp_min;
                    weatherDay.tempMax = weathers[i].main.temp_max;
                    weatherDay.humidity = weathers[i].main.humidity;
                    weatherDay.title = weathers[i].weather[0].main;
                    weatherDay.visibility = weathers[i].visibility;
                    weatherDay.windSpeed = weathers[i].wind.speed;
                    weatherDay.windDegree = weathers[i].wind.deg;

                    weather[(dayCounter - today)] = weatherDay;

                    dayCounter++;
                }
                
            }

            return weather;
        }
    }
}
