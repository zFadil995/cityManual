
using Xamarin.Forms;

namespace City_Manual
{
    class HistoryPage : TabbedPage
    {
        public HistoryPage()
        {
            Page eventsPage;
            Page placesPage;

            if (Device.OS == TargetPlatform.iOS)
            {
                eventsPage = new EventsPage() { Title = "Events", Icon = "events.png" };
                placesPage = new PlacesPage() { Title = "Places", Icon = "places.png" };
            }
            else
            {
                eventsPage = new EventsPage() { Title = "Events" };
                placesPage = new PlacesPage() { Title = "Places" };
            }
            Children.Add(eventsPage);
            Children.Add(placesPage);
        }
    }
}
