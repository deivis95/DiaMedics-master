using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DiaMedics.Views;
using DiaMedics.ViewModels;
using DiaMedics.Models.Entities;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DiaMedics
{

    public partial class App : Application
    {
        public ActivitatSetmana activitatSetmana;
        public DiaMedics.Models.Entities.DietaSetmana dietaSetmana;
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new Views.MainPage());
            this.InitData();
            //this.
        }

        public void InitData()
        {
            ArraySegment<Activitat> day;
            Activitat a;
            a = new Activitat(0, TipusActivitat.Video);
            day.Array[0] = a;
            a = new Activitat(1, TipusActivitat.Video);
            day.Array[1] = a;
            a = new Activitat(2, TipusActivitat.Caminar);
            day.Array[2] = a;

            activitatSetmana = new ActivitatSetmana();
            activitatSetmana.dilluns = day;
            activitatSetmana.dimarts = day;
            activitatSetmana.dimecres = day;
            activitatSetmana.dijous = day;
            activitatSetmana.divendres = day;
            activitatSetmana.dissabte = day;
            activitatSetmana.diumenge = day;

            ArraySegment<Apat> apats;
            Apat apat;
            //a = new Apat("Cafe amb llet",TipoApat.Esmorzar,)

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

    public static class ViewModelLocator
    {

        static MainViewModel mainvm;
        static TasksViewModel taskvm;
        static ExcerciseViewModel exervm;
        static DietViewModel dietvm;
        static LogrosViewModel logvm;
        static MySpaceViewModel spacevm;
        public static MainViewModel MainViewModel
        {
            get
            {
                if (mainvm == null)
                {
                    mainvm = new MainViewModel();
                }
                return mainvm;

            }
        }

        public static TasksViewModel TasksViewModel
        {
            get
            {
                if (taskvm == null)
                {
                    taskvm = new TasksViewModel();
                }
                return taskvm;

            }

        }

        public static ExcerciseViewModel ExcerciseViewModel
        {
            get
            {
                if (exervm == null)
                {
                    exervm = new ExcerciseViewModel();
                }
                return exervm;

            }

        }
        public static DietViewModel DietViewModel
        {

            get
            {
                if (dietvm == null)
                {
                    dietvm = new DietViewModel();
                }
                return dietvm;

            }
        }
        public static LogrosViewModel LogrosViewModel
        {
            get
            {
                if (logvm == null)
                {
                    logvm = new LogrosViewModel();
                }
                return logvm;

            }
        }
        public static MySpaceViewModel MySpaceViewModel
        {
            get
            {
                if (spacevm == null)
                {
                    spacevm = new MySpaceViewModel();
                }
                return spacevm;

            }
        }

    }
}

