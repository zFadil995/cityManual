using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace City_Manual
{
    public partial class CitiesPage : ContentPage
    {
        private ObservableCollection<City> cities;
        public CitiesPage()
        {
            InitializeComponent();
            cities = new ObservableCollection<City>();
            if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
                citiesList.HasUnevenRows = true;
            SetupCities();
            citiesList.ItemsSource = cities;

            citiesList.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                if (e.SelectedItem != null)
                {
                    ICity.chosenCity = (City)e.SelectedItem;
                    Navigation.PushModalAsync(new CityDetailPage() { Title = ((City)e.SelectedItem).name });
                    citiesList.SelectedItem = null;
                }
            };
        }

        private void SetupCities()
        {
            foreach (City city in ICity.cities)
                cities.Add(city);
        }
    }
}
