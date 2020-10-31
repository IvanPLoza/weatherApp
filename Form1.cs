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

            APIClient Api = new APIClient(); //Initialize our api client controller 
            Api.apiUrl = "http://api.openweathermap.org"; //Define api url
            Api.apiKey = "b46d222eaa2ec1c02f06e0a0e9115464"; //Define api key
            Api.lang = "hr"; //Set weather data language

            currentWeatherResponseObject data = Api.getCurrentWeatherByCity("Split");

            LocationTitle.Text = data.name;
            weatherTitle.Text = data.weather[0].title;
            weatherDescription.Text = data.weather[0].description;
            
            Debug.WriteLine(Api.getCurrentWeatherByCity("Split").name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
