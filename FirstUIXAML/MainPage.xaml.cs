using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstUIXAML
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "I am Ngoc Minh", "Cancel");
        }
    }
}
