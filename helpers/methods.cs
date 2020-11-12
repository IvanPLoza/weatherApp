/*****************
 * @author: ilozan00@fesb.hr
 * @brief: College project weather application for PRO1
 * ***************/
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks.Dataflow;
using WeatherApp.requests;
using System.IO;

namespace WeatherApp.helpers
{
    public class Helpers
    {

        //LOG FILE open and create if doesn't exists
        public static string logPath = @"c:/temp/weatherAppLogs.txt";

        //Daily weather object constructor class
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

        //Returns the formated string for UI display
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

        //Returns the formated string for UI display
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

        //Returns the formated string for UI display
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

        //Returns the formated string for UI display
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

        //Function that takes UNIX format timestamp, converts it and returns the DateTime data type date
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc); //Create 0-null timestamp
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime(); //Add input timestamp and previous null which you can convert back to date time
            return dtDateTime;
        }

        //Function that returns string array for UI display of hourly weather data - takes array of objects that include weather data
        public static string[] getFutureWeatherHourlyDisplayValues(IList <ListW> weathers, Int32 count)
        {
            string[] ret = new string[count];
            int today = DateTime.Now.Day;

            for(int i = 0; i < count; i++)
            {
                DateTime time = UnixTimeStampToDateTime(weathers[i].dt);
                ret[i] =    
                    (time.Day == today? "Today" : Convert.ToString(time.DayOfWeek)) + " " + 
                    time.ToString("hh:mm") +
                    " " +
                    getTemperatureDisplayValueFromString(weathers[i].main.temp_min) +
                    "/" +
                    getTemperatureDisplayValueFromString(weathers[i].main.temp_max);
            }

            return ret;
        }

        //Function that returns string array for UI display of future weather list boxes- takes array of objects that include weather data
        public static string[] getFutureDailyWeatherDisplayValues(DailyWeather[] weathers, string type)
        {
            string[] ret = new string[weathers.Length];

            switch (type)
            {
                //Returns the formated string for future day/forecast list UI display
                case "day":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = weathers[i].date.DayOfWeek + "/" + weathers[i].title;
                    }
                    return ret;

                //Returns the formated string for future temperature list UI display
                case "temp":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = getFutureDailyWeatherTemperature(weathers[i].tempMin, weathers[i].tempMax);
                    }
                break;

                //Returns the formated string for future visibility list UI display
                case "vis":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = getVisibilityDisplayValuesFromString(weathers[i].visibility);
                    }
                    return ret;

                //Returns the formated string for future humidty list UI display
                case "hum":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = getHumidtyDisplayValueFromString(weathers[i].humidity);
                    }
                    return ret;

                //Returns the formated string for future wind data lsit UI display
                case "wind":
                    for (int i = 0; i < weathers.Length; i++)
                    {
                        ret[i] = getWindDisplayValuesFromString(weathers[i].windSpeed, weathers[i].windDegree);
                    }
                    return ret;
            }

            return ret;
        }

        //Returns formated string from values for listbox items of temeparture
        public static string getFutureDailyWeatherTemperature(string min, string max)
        {
            return getTemperatureDisplayValueFromString(min) + "/" + getTemperatureDisplayValueFromString(max);
        }

        //Returns the url for the icon resource
        public static string getIconUrl(string icon)
        {
            return "http://openweathermap.org/img/wn/" + icon + "@2x.png";
        }

        //Returns the formated string from values for listbox items of humidty
        public static string getFutureDailyWeatherHumidty(DailyWeather weather)
        {
            return getHumidtyDisplayValueFromString(weather.humidity);
        }

        //Returns the formated string for visibility data
        public static string getFutureDailyWeatherVisiblity(DailyWeather weather)
        {
            return getVisibilityDisplayValuesFromString(weather.visibility);
        }

        //Function that returns array of objects that are used for "Tjedni pregled", future daily weather forecast
        public static DailyWeather[] getFutureDailyWeatherList(IList <ListW> weathers, int count)
        {
            DailyWeather[] weather = new DailyWeather[5];   //Only have one weather per day - gives a 5 total
            DateTime today = DateTime.Now;                  //Get current date so we can compare the long list of weathers and take only days
            DateTime dayCounterDate = today;                //This is used as compare value if date was already repeated
            int dayCounter = 0;                             //Counter for array

            for (int i = 0; i < count; i++)
            {
                DateTime date = UnixTimeStampToDateTime(weathers[i].dt); //Convert timestamp to date using helper function
            
                if (DateTime.Compare(date, dayCounterDate) > 0) //Check if date from input is later than previous
                {
                    //if true, then insert the daily weather object to array which is one of the 5 days
                    DailyWeather weatherDay = new DailyWeather();

                    //Map data
                    weatherDay.date = UnixTimeStampToDateTime(weathers[i].dt);
                    weatherDay.tempMin = weathers[i].main.temp_min;
                    weatherDay.tempMax = weathers[i].main.temp_max;
                    weatherDay.humidity = weathers[i].main.humidity;
                    weatherDay.title = weathers[i].weather[0].main;
                    weatherDay.visibility = weathers[i].visibility;
                    weatherDay.windSpeed = weathers[i].wind.speed;
                    weatherDay.windDegree = weathers[i].wind.deg;

                    //Insert object
                    weather[dayCounter] = weatherDay;

                    //Add the logic counters
                    dayCounterDate = dayCounterDate.AddDays(1);
                    dayCounter++;
                }
                
            }

            return weather;
        }

        public static void createLog(string log)
        {
            using (StreamWriter sw = File.AppendText(logPath))
            {
                sw.WriteLine("{0}: {1}", Environment.UserName, log);
            }
        }

        public static void appStartLog()
        {
            if (!File.Exists(logPath))
            {
                using (StreamWriter sw = File.CreateText(logPath))
                {
                    sw.WriteLine("======== {0} ========", DateTime.Now.ToString());
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(logPath))
                {
                    sw.WriteLine("======== {0} ========", DateTime.Now.ToString());
                }
            }
        }
    }
}
