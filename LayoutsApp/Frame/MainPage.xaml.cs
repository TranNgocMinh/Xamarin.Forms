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
            var frame = new Frame();

            var myLabel = new Label
            {
                Text = "I am a Label",
                Margin = 5,
                BackgroundColor = Color.Red,
                HorizontalOptions= LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            frame.Content = myLabel;
            frame.OutlineColor = Color.Red;
            frame.CornerRadius = 10;
            frame.HasShadow = true;
            frame.Margin = 20;
            
           
            Content = frame;


        }
    }
}
