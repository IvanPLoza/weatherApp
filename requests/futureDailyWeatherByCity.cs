/*****************
 * @author: ilozan00@fesb.hr
 * @brief: College project weather application for PRO1
 * ***************/
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.requests
{
    public class futureDailyWeatherByCityResponseObject : ErrorList
    {
        public int cnt { get; set; }

        public IList<ListW> list { get; set; }

    }
}
