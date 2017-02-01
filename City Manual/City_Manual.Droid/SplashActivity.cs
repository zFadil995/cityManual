using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using Android.Content.PM;

namespace City_Manual.Droid
{
    [Activity(Label = "City Manual", Icon = "@drawable/icon", Theme = "@style/MyTheme.Splash", MainLauncher =true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        protected override void OnResume()
        {
            base.OnResume();

            Task startupWork = new Task(() =>
            {
                Task.Delay(250);
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            });
            startupWork.Start();
        }
    }
}