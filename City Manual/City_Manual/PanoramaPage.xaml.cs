using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace City_Manual
{
    public partial class PanoramaPage : CarouselPage
    {
        public PanoramaPage()
        {
            InitializeComponent();
            List<ContentPage> pages = new List<ContentPage>(0);
            //string[] sources = { "tuzla_1.jpg", "tuzla_2.jpg", "tuzla_3.jpg", "tuzla_4.jpg", "tuzla_5.jpg" };
            foreach (string source in ICity.chosenCity.panoramas)
                pages.Add(new ContentPage
                {
                    Content = new StackLayout
                    {
                        Children = {
                           new Image {Source = source, HorizontalOptions=LayoutOptions.Fill, VerticalOptions = LayoutOptions.CenterAndExpand, Margin = new Thickness(5, 5, 5, 5) }
                        }
                    }
                });
            //this.Children.RemoveAt(0);
            foreach (ContentPage page in pages)
                this.Children.Add(page);
        }
    }
}
