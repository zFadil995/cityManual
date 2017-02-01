using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace City_Manual
{
    public class App : Application
    {
        public App()
        {
            ICity.getCities();
            MainPage = new NavigationPage(new CitiesPage() { Title = "City Manual" });
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
