using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DiaMedics.ViewModels;
using DiaMedics.Models;
using MvvmHelpers;
using DiaMedics;
namespace DiaMedics.Views

{
	
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TasksPageDiari: ContentPage
    {
        TasksViewModel vm;
        public TasksPageDiari ()
        {
            InitializeComponent();
            BindingContext = vm = ViewModelLocator.TasksViewModel;


            //vm.dataTasks.CollectionChanged += (sender, e);
            listView.ItemsSource = vm.dataTasks;
            /*DataTask d = new DataTask(TipusTask.Dieta);
            listView.ItemsSource = d;*/
		}

    }
}
