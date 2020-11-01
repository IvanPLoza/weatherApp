using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.helpers;
using WeatherApp.requests;

namespace WeatherApp
{

    public partial class Form1 : Form
    {
        private Helpers Helpers; //Initialize helper methods
        private APIClient Api = new APIClient(); //Initialize our api client controller 

        public Form1()
        {
            InitializeComponent();
        }

        private void refreshWeatherData()
        {
            currentWeatherResponseObject dataCurrent = Api.getCurrentWeatherByCity(Api.city);            //Request current weather data
            futureDailyWeatherByCityResponseObject dataDaily = Api.getFutureDailyWeatherByCity(Api.city);//Request future weather data


            if (dataCurrent.errorMessages == null)
            {
                loadCurrentWeatherData(dataCurrent);    //Display the current weather values
                loadFutureWeatherData(dataDaily);       //Display the future weather values
            }
            else
            {
                //If error happens log into debug and let user know there is an error
                LocationTitle.Text = "ERROR";
                Debug.WriteLine(dataCurrent.errorMessages);
                Debug.WriteLine(dataDaily.errorMessages);
            }
        }

        private void loadFutureWeatherData(futureDailyWeatherByCityResponseObject dataDaily)
        {
            //Future hourly weather display values
            futureHourlyWeatherDisplay.Items.Clear(); //Clear previous values if there were any
            futureHourlyWeatherDisplay.Items.AddRange(Helpers.getFutureWeatherHourlyDisplayValues(dataDaily.list, dataDaily.cnt));

            //Future daily weather display values
            Helpers.DailyWeather[] weatherDays = Helpers.getFutureDailyWeatherList(dataDaily.list, dataDaily.cnt);
            futureWeatherDayDisplay.Items.Clear(); //Clear previous values if there were any
            futureWeatherTempDisplay.Items.Clear(); //Clear previous values if there were any
            futureWeatherVisibilityDisplay.Items.Clear(); //Clear previous values if there were any
            futureWeatherHumidtyDisplay.Items.Clear(); //Clear previous values if there were any
            futureWeatherWindDisplay.Items.Clear(); //Clear previous values if there were any
            futureWeatherDayDisplay.Items.AddRange(Helpers.getFutureDailyWeatherDisplayValues(weatherDays, "day"));
            futureWeatherTempDisplay.Items.AddRange(Helpers.getFutureDailyWeatherDisplayValues(weatherDays, "temp"));
            futureWeatherVisibilityDisplay.Items.AddRange(Helpers.getFutureDailyWeatherDisplayValues(weatherDays, "vis"));
            futureWeatherHumidtyDisplay.Items.AddRange(Helpers.getFutureDailyWeatherDisplayValues(weatherDays, "hum"));
            futureWeatherWindDisplay.Items.AddRange(Helpers.getFutureDailyWeatherDisplayValues(weatherDays, "wind"));
        }

        private void loadCurrentWeatherData(currentWeatherResponseObject dataCurrent)
        {
            //Current weather display values
            LocationTitle.Text = dataCurrent.name;
            weatherIcon.Load(Helpers.getIconUrl(dataCurrent.weather[0].icon));
            weatherDescription.Text = dataCurrent.weather[0].description;
            temperatureValueDisplay.Text = Helpers.getTemperatureDisplayValueFromString(dataCurrent.main.temp);
            temperatureMinMaxDisplay.Text = Helpers.getTemperatureDisplayValueFromString(dataCurrent.main.temp_min) + "/" + Helpers.getTemperatureDisplayValueFromString(dataCurrent.main.temp_max);
            humidityValueDisplay.Text = Helpers.getHumidtyDisplayValueFromString(dataCurrent.main.humidity);
            windValueDisplay.Text = Helpers.getWindDisplayValuesFromString(dataCurrent.wind.speed, dataCurrent.wind.deg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Api.unit = "metric";                                //Use metric values 
            Api.city = "Split";                                 //Let the default city to be Split, Croatia
            Api.lang = "hr";                                    //Set desired language for the weather data
            Api.apiUrl = "http://api.openweathermap.org";       //Set api url
            Api.apiKey = "b46d222eaa2ec1c02f06e0a0e9115464";    //Set api key

            citySelector.SelectedIndex = citySelector.FindStringExact(Api.city); //Set default city

            refreshWeatherData();   //Load for the first time
        }

        private void citySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Api.city = citySelector.SelectedItem.ToString(); //Set city

            refreshWeatherData(); //Refresh and request new data
        }
    }
}
