using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts.Forms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;
//using Entry = DiaMedics.Models.Entities.Entry;
using Entry = Microcharts.Entry;
//using DiaMedics.Layouts;

namespace DiaMedics.Views
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgresPage : ContentPage
	{
		List<Entry> entries = new List<Entry>
		{
			new Entry(200) {
				Color = SKColor.Parse("#FF1493"),
				Label = "Monday",
				ValueLabel="200"
			},
			new Entry(400) {
				Color = SKColor.Parse("#FF1493"),
				Label = "Tuesday",
				ValueLabel="200"
			},
			new Entry(800) {
				Color = SKColor.Parse("#FF1493"),
				Label = "Wednesday",
				ValueLabel="200"
			},
			new Entry(1000) {
				Color = SKColor.Parse("#FF1493"),
				Label = "Thursday",
				ValueLabel="200"
			}
		};
		public ProgresPage ()
		{
			InitializeComponent ();
			chart2.Chart = new Microcharts.LineChart() { Entries = entries };
			//var entries = // ... see 1°) above
			//var chart = // ... see 2°) above
		}
	}
}