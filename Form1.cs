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

            currentWeatherResponseObject data = Api.getCurrentWeatherByCity("Split");

            LocationTitle.Text = data.name;
            weatherTitle.Text = data.weather[0].main;
            weatherDescription.Text = data.weather[0].description;
            temperatureValueDisplay.Text = Helpers.getTemperatureDisplayValueFromString(data.main.temp);
            temperatureMinMaxDisplay.Text = Helpers.getTemperatureDisplayValueFromString(data.main.temp_min) + "/" + Helpers.getTemperatureDisplayValueFromString(data.main.temp_max);
            humidityValueDisplay.Text = Helpers.getHumidtyDisplayValueFromString(data.main.humidty);
            windValueDisplay.Text = Helpers.getWindDisplayValuesFromString(data.wind.speed, data.wind.deg);
            Debug.WriteLine(data);
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
    }
}
