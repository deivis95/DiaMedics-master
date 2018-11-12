using System;
using MvvmHelpers;
using Mvvmicro;
using Xamarin.Forms;
using DiaMedics.ListViews;
namespace DiaMedics.Models
{
    public class DietToday : ObservableObject
    {
        public ViewCell cell;

        public DietToday()
        {
            cell = new DietaCell();
        }
    }
}