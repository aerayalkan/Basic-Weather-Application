using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace Weather_Application
{
    internal class WeatherInfo
    {
        public class coord
        {
            public double lon { get; set; }
            public double lan { get; set; }
        }
        
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
        }

        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }

            public DateTime GetsunriseDateTime()
            {
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(sunrise);

                DateTime dateTime = dateTimeOffset.DateTime;
                
                return dateTime;
            }

            public DateTime GetsunsetDateTime()
            {
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(sunset);
                
                DateTime dateTime = dateTimeOffset.DateTime;
                
                return dateTime;
            }
        }

        public class root
        {
            public coord coord { get; set; }
            public List <weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
              
        }
    }
}
