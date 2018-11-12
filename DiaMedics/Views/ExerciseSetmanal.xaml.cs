using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DiaMedics.Models;
using Syncfusion.XForms.ProgressBar;

namespace DiaMedics.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExerciseSetmanal : ContentPage
	{
		public ExerciseSetmanal ()
		{
			InitializeComponent ();
            //DataTask d = new DataTask();
            //listView.ItemsSource = d.ObservableTaskDiari;
        }
	}
}