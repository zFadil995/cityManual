using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace City_Manual
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.White;
            historicalEvents.Text = ICity.chosenCity.events;
        }
    }
}
