using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using DiaMedics.Views;
using Xamarin.Forms;
using Urho;
using Urho.Forms;
using DiaMedics;
namespace DiaMedics.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public LoginViewModel LoginVM
        {
            get;
            set;
        }

        public ExcerciseViewModel ExcerciseVM
        {
            get;
            set;
        }

        public DietViewModel DietVM
        {
            get;
            set;
        }

        public TasksViewModel TasksVM
        {
            get;
            set;
        }
        public LogrosViewModel LogrosVM
        {
            get;
            set;
        }
        public MySpaceViewModel MySpaceVM
        {
            get;
            set;
        }
        #region Constructors

        public MainViewModel()
        {
            instance = this;
            /*this.LoginVM = new LoginViewModel();
            this.TasksVM = new TasksViewModel();
            this.DietVM = new DietViewModel();
            this.ExcerciseVM = new ExcerciseViewModel();
            this.MySpaceVM = new MySpaceViewModel();*/

        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion*/






        #region Commands
        public ICommand ExerciseCommand
        {
            get
            {
                return new RelayCommand(Excercise);
            }
        }

        private async void Excercise()
        {

            MainViewModel.GetInstance().ExcerciseVM = ViewModelLocator.ExcerciseViewModel;
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new ExerciseTabbedPage());
        }

        public ICommand DietaCommand
        {
            get
            {
                return new RelayCommand(Dieta);
            }
        }

        private async void Dieta()
        {

            MainViewModel.GetInstance().DietVM = ViewModelLocator.DietViewModel;
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new DietTabbedPage());
        }

        public ICommand TasksCommand
        {
            get
            {
                return new RelayCommand(Tasks);
            }
        }

        private async void Tasks()
        {
            MainViewModel.GetInstance().TasksVM = ViewModelLocator.TasksViewModel;
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new TasksTabbedPage()); //PROVOCA NOVA INSTANCIA NO NECESSARIA DE LA VIEW MODEL
        }

        public ICommand LogrosCommand
        {
            get
            {
                return new RelayCommand(Logros);
            }
        }

        private async void Logros()
        {
            MainViewModel.GetInstance().LogrosVM = ViewModelLocator.LogrosViewModel;
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new LogrosPage());
        }

        public ICommand MySpaceCommand
        {
            get
            {
                return new RelayCommand(MySpace);
            }
        }

        private async void MySpace()
        {
            MainViewModel.GetInstance().MySpaceVM = ViewModelLocator.MySpaceViewModel;
            await  Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new MySpacePage());
        }
        #endregion


    }

    public class UrhoPage : ContentPage
    {
        UrhoSurface urhoSurface;
        public UrhoPage()
        {
            urhoSurface = new UrhoSurface();
            urhoSurface.VerticalOptions = LayoutOptions.FillAndExpand;
            Content = new StackLayout
            {
                
                Padding = new Thickness(12, 12, 12, 40),
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    urhoSurface,
                    new Label {Text = "3D"}
                }
            };
        }
        protected override async void OnAppearing()
        {
            StartUrhoApp();
        }

        async void StartUrhoApp()
        {

        }
    }


}

