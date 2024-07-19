using Newtonsoft.Json;
using System.Net;

namespace Weather_Application
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            TBCity.KeyDown += new KeyEventHandler(TBCity_KeyDown);
        }

        string APIKey = "API KEY";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           getWeather();
        }

        private void TBCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getWeather();
                e.SuppressKeyPress = true;
            }
        }

        void getWeather()
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var Json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(Json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = Info.sys.GetsunsetDateTime().ToString();
                labSunrise.Text = Info.sys.GetsunriseDateTime().ToString();

                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString() + " hPa";
            }
        }
    }
}
