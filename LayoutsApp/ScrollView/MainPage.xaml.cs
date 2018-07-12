using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutsApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{

            // InitializeComponent();
            var scroll = new ScrollView();
          
            var myLabel = new Label
            {
                Text = "I am a Label",
                Margin = 5,
                BackgroundColor = Color.Red,
                HeightRequest=600,
                WidthRequest = 150
            };
            scroll.Content = myLabel;
            Content = scroll;

        }
    }
}
