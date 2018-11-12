using System;
using Mvvmicro.Extensions;
using Xamarin.Forms;
using MvvmHelpers;
using XLabs.Forms;
using DiaMedics.ListViews;
namespace DiaMedics.Models
{
    public enum TipusTask{
        Dieta, Exercici, Pastilles, ExerciciSet,
    }

    public class DataTask :ObservableObject

    {
        public ViewCell cell;
        public TipusTask tipustask;

        public DataTask (TipusTask tipus)
        {
            this.tipustask = tipus;
            switch (tipus)
            {
                case TipusTask.Dieta:
                    cell = new TaskDietCell();
                    break;
                case TipusTask.Exercici:
                    cell = new TaskCellExercise();
                    break;
                case TipusTask.Pastilles:
                    cell = new TaskCellPills();
                    break;
                case TipusTask.ExerciciSet:
                    cell = new TaskCellSetmanalExercise();
                    break;
                default:
                    break;
            }
        }
    }
}

