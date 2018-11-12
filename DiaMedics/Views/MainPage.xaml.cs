using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.XForms.ProgressBar;
using DiaMedics.ViewModels;
using Syncfusion.SfNavigationDrawer.XForms;
using Syncfusion.SfNavigationDrawer;



namespace DiaMedics.Views

{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        //MenuViewModel menuvm;
        public MainPage ()

		{
			InitializeComponent();
			navigationDrawer.DrawerWidth = 200;
			hamburgerButton.Image = (FileImageSource)ImageSource.FromFile("icons8_list_48.png");
			List<string> list = new List<string>();
			list.Add("Perfil");
			list.Add("Salir");
			listView.ItemsSource = list;

		}	

		void hamburgerButton_Clicked(object sender, EventArgs e)
		{

			navigationDrawer.ToggleDrawer();

		}

		private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			// Your codes here
			navigationDrawer.ToggleDrawer();
		}

	}

}
	