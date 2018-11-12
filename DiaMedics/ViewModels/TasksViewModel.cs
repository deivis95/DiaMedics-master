using System;
using DiaMedics.Models;
using Xamarin.Forms;
using MvvmHelpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DiaMedics.ViewModels
{
    public class TasksViewModel : BaseViewModel
    {
        private ObservableRangeCollection<DataTask> dataTaskslist;

        public ObservableRangeCollection<DataTask> dataTasks {
            get { return dataTaskslist; }
            set { dataTaskslist = value; }
        }
        private ObservableRangeCollection<DataTask> dataTaskslistsetmanal;
        public ObservableRangeCollection<DataTask> dataTasksSetmanals
        {
            get { return dataTaskslistsetmanal; }
            set { dataTaskslistsetmanal = value; }
        }




        public TasksViewModel()
        {
            ObservableRangeCollection < DataTask > d0 = new ObservableRangeCollection<DataTask>();
            DataTask d1 = new DataTask(TipusTask.Dieta);
            DataTask d2 = new DataTask(TipusTask.Exercici);
            DataTask d3 = new DataTask(TipusTask.Pastilles);
            d0.Add(d1);
            d0.Add(d2);
            d0.Add(d3);
            dataTasks = d0;

            ObservableRangeCollection<DataTask> d00 = new ObservableRangeCollection<DataTask>();
            DataTask d10 = new DataTask(TipusTask.ExerciciSet);
            d00.Add(d10);
            dataTasksSetmanals = d00;
        }
    }

}

