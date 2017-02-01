using System;
using Xamarin.Forms;

namespace City_Manual
{
    public class Option
    {
        public string option { get; set; }
        public Option(string option)
        {
            this.option = option;
        }
        public override string ToString()
        {
            return option;
        }
    }
    public class CityDetailPage : MasterDetailPage
    {
        public CityDetailPage()
        {
            Option[] options = new []
                {
                    new Option("Cities List"),
                    new Option("Information"),
                    new Option("Panorama"),
                    new Option("History")
                };

            Label header = new Label
            {
                Text = "City",
                FontSize = 40,
                HorizontalOptions = LayoutOptions.Start
            };
            
            ListView listView = new ListView
            {
                ItemsSource = options
            };


            this.Master = new ContentPage
            {
                Title = "City",
                Padding = new Thickness(5, 20, 5, 10),
                Content = new StackLayout
                {
                    Children =
                    {
                        header,
                        listView
                    }
                }
            };

            listView.ItemSelected += (sender, args) =>
            {
                switch (args.SelectedItem.ToString())
                {
                    case "Cities List":
                        Navigation.PopModalAsync();
                        break;
                    case "Information":
                        this.Detail = new NavigationPage(new InformationPage() { Title = "Information" });
                        break;
                    case "Panorama":
                        this.Detail = new NavigationPage(new PanoramaPage() { Title = "Panorama" });
                        break;
                    case "History":
                        this.Detail = new NavigationPage(new HistoryPage() { Title = "History" });
                        break;
                    default:
                        break;
                }
                if (args.SelectedItem.ToString() != "Cities List")
                    this.Detail.BindingContext = args.SelectedItem;
                this.IsPresented = false;
            };
                listView.SelectedItem = options[1];
            this.IsPresented = false;

        }
    }
}
