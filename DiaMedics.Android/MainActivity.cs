
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace DiaMedics.Droid
{
	[Activity(Label = "DiaMedics", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        /*Entry[] entries = new[]
        {
            new Entry(200) {
                Color = SKColor.Parse("#FF1493"),
                Label = "Monday",
                ValueLabel="200"
            }
        };*/

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            /*var chart = new BarChart() { Entries = entries };
            var chartView = FindViewById<ChartView>(Resource.Id.chartView);
            chartView.Chart = chart;*/
        }
    }
}

