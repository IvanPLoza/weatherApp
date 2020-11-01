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
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Helpers Helpers; //Initialize helper methods
            APIClient Api = new APIClient(); //Initialize our api client controller 
            Api.apiUrl = "http://api.openweathermap.org"; //Define api url
            Api.apiKey = "b46d222eaa2ec1c02f06e0a0e9115464"; //Define api key

            currentWeatherResponseObject dataCurrent = Api.getCurrentWeatherByCity("Split");
            futureDailyWeatherByCityResponseObject dataDaily = Api.getFutureDailyWeatherByCity("Split");

            
            if (dataCurrent.errorMessages == null)
            {
                //Current weather display values
                LocationTitle.Text = dataCurrent.name;
                weatherTitle.Text = dataCurrent.weather[0].main;
                weatherDescription.Text = dataCurrent.weather[0].description;
                temperatureValueDisplay.Text = Helpers.getTemperatureDisplayValueFromString(dataCurrent.main.temp);
                temperatureMinMaxDisplay.Text = Helpers.getTemperatureDisplayValueFromString(dataCurrent.main.temp_min) + "/" + Helpers.getTemperatureDisplayValueFromString(dataCurrent.main.temp_max);
                humidityValueDisplay.Text = Helpers.getHumidtyDisplayValueFromString(dataCurrent.main.humidity);
                windValueDisplay.Text = Helpers.getWindDisplayValuesFromString(dataCurrent.wind.speed, dataCurrent.wind.deg);

                //Future hourly weather display values
                futureHourlyWeatherDisplay.Items.AddRange(Helpers.getFutureWeatherHourlyDisplayValues(dataDaily.list, dataDaily.cnt));

                //Future daily weather display values
                Helpers.DailyWeather[] weatherDays = Helpers.getFutureDailyWeatherList(dataDaily.list, dataDaily.cnt);
                futureWeatherDayDisplay.Items.AddRange(Helpers.getFutureDailyWeatherDayDisplayValues(weatherDays, weatherDays.Length));

            }
            else
            {
                LocationTitle.Text = "ERROR";
                Debug.WriteLine(dataCurrent.errorMessages);
                Debug.WriteLine(dataDaily.errorMessages);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void temperatureDisplay_Click(object sender, EventArgs e)
        {

        }

        private void weatherDescription_Click(object sender, EventArgs e)
        {

        }

        private void weatherTitle_Click(object sender, EventArgs e)
        {

        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
