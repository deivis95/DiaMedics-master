using System;
using DiaMedics.Models;
using Xamarin.Forms;
using MvvmHelpers;
using DiaMedics.ListViews;

namespace DiaMedics.DataTemplates
{
    public class TemplateSelectorDieta : DataTemplateSelector
    {
        public DataTemplate DietaTodayDataTemplate;

        public TemplateSelectorDieta()
        {
            this.dietaTodayDataTemplate = new DataTemplate(typeof(DiaMedics.ListViews.DietaCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Cell = item as DietToday;
            return this.dietaTodayDataTemplate;

        }

        private readonly DataTemplate dietaTodayDataTemplate;
    }
}
