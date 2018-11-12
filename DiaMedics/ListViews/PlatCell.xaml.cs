using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiaMedics.ListViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatCell : ViewCell
	{
		public PlatCell ()
		{
			InitializeComponent ();
		}
	}
}