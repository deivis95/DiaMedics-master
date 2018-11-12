using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DiaMedics.ViewModels;
using DiaMedics.Models;
using MvvmHelpers;
using DiaMedics;

namespace DiaMedics.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TasksPageSetmanal : ContentPage
	{
        TasksViewModel vm;
		public TasksPageSetmanal ()
		{
			InitializeComponent ();
            BindingContext = vm = ViewModelLocator.TasksViewModel;


            //vm.dataTasks.CollectionChanged += (sender, e);
            listView.ItemsSource = vm.dataTasksSetmanals;
        }
	}
}