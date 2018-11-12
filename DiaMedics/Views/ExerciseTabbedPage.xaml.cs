using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiaMedics.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExerciseTabbedPage : TabbedPage
	{
		public ExerciseTabbedPage ()
		{
			InitializeComponent ();
		}
	}
}