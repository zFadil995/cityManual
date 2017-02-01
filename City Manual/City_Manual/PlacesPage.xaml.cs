using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace City_Manual
{
    public partial class PlacesPage : ContentPage
    {
        public PlacesPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.White;
            placesList.ItemsSource = ICity.chosenCity.places;
            placesList.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                placesList.SelectedItem = null;
            };
        }
    }
}
