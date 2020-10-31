using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.CodeDom.Compiler;

namespace WeatherApp
{
    //Define request methods that can be used within the api client object
    public enum requestMethods
    {
        GET,
        POST
    }

    class APIClient
    {
        public string apiUrl = ""; //Api url which initialy is not set 
        public string apiKey = ""; //API key for weather api
        public string lang = "hr"; //Api language 
        public requestMethods method = requestMethods.GET; //HTTP method selector which default is GET

        //Method that creates and sends request to the api and then returns the raw response
        public string createApiRequest(string request = "") 
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(apiUrl + "/data/2.5/weather?" + request + "&lang=" + lang + "&appid=" + apiKey); //Initialize request object
            HttpWebResponse response = null; //Create response object
            string retValue = ""; //Return value which is JSON response for our weather api

            req.Method = method.ToString(); //Set request method

            try
            {
                response = (HttpWebResponse)req.GetResponse(); //Send request and await for the reponse

                //Piece of code that converts our response format from JSON, HTML... to string
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            retValue = reader.ReadToEnd(); //Set return value which is string format of web req response
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                //Set return value to be error code if above didn't work out for some reason
                retValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose(); //Clean resources from the app if the method did return valid response
                }
            }

            return retValue; //Return the response in string format
        }

        //Method to fetch current weather by city that returns object containing values
        public currentWeatherResponseObject getCurrentWeatherByCity(string city)
        {
            return JsonConvert.DeserializeObject<currentWeatherResponseObject>(createApiRequest("q=" + city));
        }
    }
}
