using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace City_Manual
{
    public partial class InformationPage : ContentPage
    {
        public InformationPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.White;
            cityName.Text = ICity.chosenCity.name;
            cityWebsite.Text = ICity.chosenCity.website;
            cityPhone.Text = ICity.chosenCity.phoneNumber;
            cityeMail.Text = ICity.chosenCity.email;
            cityLocation.Source = ICity.chosenCity.location.source;
        }
        public void onWebsiteTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(ICity.chosenCity.website));
        }
        public void onPhoneTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:" + ICity.chosenCity.phoneNumber));
        }
        public void oneMailTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:" + ICity.chosenCity.email));
        }
        public void onLocationTapped(object sender, EventArgs e)
        {
            Device.OnPlatform(
                iOS: () =>
                {
                    Device.OpenUri(new Uri(String.Format("http://maps.apple.com/maps?daddr={0} {1}&t=h", ICity.chosenCity.location.latitude.ToString(), ICity.chosenCity.location.longtitude.ToString())));
                },
                Android: () =>
                {
                    Device.OpenUri(new Uri(String.Format("geo:{0},{1}", ICity.chosenCity.location.latitude.ToString(), ICity.chosenCity.location.longtitude.ToString())));
                },
                WinPhone: () =>
                {
                    Device.OpenUri(new Uri(String.Format("bingmaps:?destination.latitude={0}&destination.longitude={1}", ICity.chosenCity.location.latitude.ToString(), ICity.chosenCity.location.longtitude.ToString())));
                });
        }
    }
}
