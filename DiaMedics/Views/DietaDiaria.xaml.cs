using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DiaMedics.ViewModels;

namespace DiaMedics.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DietaDiaria : ContentPage
	{
        DietViewModel vm;
        public DietaDiaria ()
		{
			InitializeComponent ();
            InitializeComponent();
            BindingContext = vm = ViewModelLocator.DietViewModel;

            //vm.dataTasks.CollectionChanged += (sender, e);
            listViewdietadiari.ItemsSource = vm.dietaDay;
        }
	}
}