using System;

using Xamarin.Forms;

namespace DiaMedics.ListViews
{
    public class MyDataTemplateSelectorTask : DataTemplateSelector
    {
        private readonly DataTemplate task1;

        public MyDataTemplateSelectorTask()
        {
            this.task1 = new DataTemplate(typeof(TaskCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return task1;
        }

    }
}

