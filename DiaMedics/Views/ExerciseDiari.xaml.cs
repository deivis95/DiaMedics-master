using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts.Forms;
using Mvvmicro;
using System.Linq;
using SkiaSharp;
//using Entry = DiaMedics.Models.Entities.Entry;
using Entry = Microcharts.Entry;
//using DiaMedics.Layouts;
using DiaMedics.Models;
using Syncfusion.XForms.ProgressBar;
using DiaMedics.ViewModels;


namespace DiaMedics.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExerciseDiari : ContentPage
    {
        ExcerciseViewModel vm;
        public ExerciseDiari()
        {
            InitializeComponent();
            BindingContext = vm = ViewModelLocator.ExcerciseViewModel;
            listView.ItemsSource = vm.exercises;
            //DataTask d = new DataTask();
			//listView.ItemsSource = d.ObservableTaskDiari;

		}
    }
}
