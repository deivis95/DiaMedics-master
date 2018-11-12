using System;
using MvvmHelpers;
using Xamarin.Forms;
using DiaMedics.Models.Entities;
using DiaMedics.ListViews;
using DiaMedics.Models;
namespace DiaMedics.ViewModels
{
    public class ExcerciseViewModel : BaseViewModel
    {
        private ObservableRangeCollection<Activitat> execlist;
        public ObservableRangeCollection<Activitat> exercises
        {
            get { return execlist; }
            set { execlist = value; }
        }

        public ExcerciseViewModel()
        {
            ObservableRangeCollection<Activitat> d0 = new ObservableRangeCollection<Activitat>();
            Activitat d1 = new Activitat();
            Activitat d2 = new Activitat();
            d0.Add(d1);
            d0.Add(d2);
            execlist = d0;
        }

    }
}

