using System;
using DiaMedics.ViewModels;
namespace DiaMedics.Infraestructure
{

    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }

        public TasksViewModel Tasks
        {
            get;
            set;
        }
        #endregion

        #region Constructor

        public InstanceLocator()
        {
            //this.Main = new MainViewModel();
            //this.Tasks = new TasksViewModel();
        }
        #endregion

    }
}
