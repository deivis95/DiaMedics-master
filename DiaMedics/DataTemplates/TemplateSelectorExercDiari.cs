using System;

using Xamarin.Forms;
using DiaMedics.ListViews;
using DiaMedics.Models;
namespace DiaMedics.DataTemplates
{
    public class TemplateSelectorExercDiari : DataTemplateSelector
    {
        public DataTemplate dataTemplate;

        public TemplateSelectorExercDiari()
        {
            this.exerDiariTemplate = new DataTemplate(typeof(ExerciseCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return this.exerDiariTemplate;
        }

        private readonly DataTemplate exerDiariTemplate;

    }
}
