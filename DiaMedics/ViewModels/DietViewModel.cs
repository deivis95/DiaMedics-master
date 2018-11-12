using System;
using DiaMedics.Models;
using Xamarin.Forms;
using MvvmHelpers;
using DiaMedics.Models.Entities;

namespace DiaMedics.ViewModels
{
    public class DietViewModel : ContentPage
    {
        private ObservableRangeCollection<Apat> dietaDayList;
        public ObservableRangeCollection<Apat> dietaDay
        {
            get { return dietaDayList; }
            set { dietaDayList = value; }
        }

        public DietViewModel()
        {
            ObservableRangeCollection<Apat> d0 = new ObservableRangeCollection<Apat>();
            Apat d1 = new Apat();
            Apat d2 = new Apat();
            Apat d3 = new Apat();
            d0.Add(d1);
            d0.Add(d2);
            d0.Add(d3);
            dietaDay = d0;
        }
    }
}
    


