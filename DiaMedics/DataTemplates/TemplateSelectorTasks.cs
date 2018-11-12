using System;

using Xamarin.Forms;
using DiaMedics.ListViews;
using DiaMedics.Models;

namespace DiaMedics.DataTemplates
{
    public class TemplateSelectorTasks : DataTemplateSelector
    {

        public DataTemplate DietaDataTemplate;
        public DataTemplate ExcerciseDataTemplate;
        public DataTemplate PillsDataTemplate;
        public DataTemplate ExcerciseSetDataTemplate;

        public TemplateSelectorTasks()
        {
            this.dietaDataTemplate = new DataTemplate(typeof(TaskDietCell));
            this.excerciseDataTemplate = new DataTemplate(typeof(TaskCellExercise));
            this.pillsDataTemplate = new DataTemplate(typeof(TaskCellPills));
            this.excerciseSetDataTemplate = new DataTemplate(typeof(TaskCellSetmanalExercise));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Cell = item as DataTask;
            return Cell.tipustask == TipusTask.Dieta 
                ? this.dietaDataTemplate
                           : Cell.tipustask == TipusTask.ExerciciSet ? this.excerciseSetDataTemplate
                           : Cell.tipustask == TipusTask.Exercici ? this.excerciseDataTemplate : this.pillsDataTemplate;
        }

        private readonly DataTemplate dietaDataTemplate;
        private readonly DataTemplate excerciseDataTemplate;
        private readonly DataTemplate pillsDataTemplate;
        private readonly DataTemplate excerciseSetDataTemplate;
    }
}

