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
            var contentView = new ContentView();

            var myLabel = new Label
            {
                Text = "I am a Label",
                BackgroundColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            contentView.Content = myLabel;
            contentView.Padding = 25;
            contentView.Margin = 10;
            contentView.BackgroundColor = Color.Aqua;

            Content = contentView;



        }
    }
}
