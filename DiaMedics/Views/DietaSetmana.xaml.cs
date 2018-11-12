using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DiaMedics.Models;
using Syncfusion.SfSchedule.XForms;

namespace DiaMedics.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DietaSetmana : ContentPage
	{
		public DietaSetmana ()
		{
			InitializeComponent ();
			{
				InitializeComponent();
				schedule = new SfSchedule();
			}
		}
	}
}