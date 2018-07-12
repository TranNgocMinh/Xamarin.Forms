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
			

            var layout = new StackLayout();
            layout.Orientation = StackOrientation.Vertical;
            //layout.Orientation = StackOrientation.Horizontal;
            layout.Margin = 5;
            var myLabel = new Label
            {
                Text = "I am a Label",
                Margin = 5
            };
            var myButton = new Button
            {
                Text = "I am a Button",
                Margin = 5
            };
            layout.Children.Add(myLabel);
            layout.Children.Add(myButton);

            //InitializeComponent();
            Content = layout;
            
        }
    }
}
