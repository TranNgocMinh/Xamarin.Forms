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

            //InitializeComponent();

            //create a new layout
            var layout = new AbsoluteLayout();

            var myLabel = new Label
            {
                Text = "I am a Label",
                Margin = 5,
                BackgroundColor = Color.Red 
            };
            var myButton = new Button
            {
                Text = "I am a Button",
                Margin = 5
            };
            //adding controls to AbsoluteLayout

            AbsoluteLayout.SetLayoutBounds(myLabel, new Rectangle(0, 0, 0.25, 0.25));
            AbsoluteLayout.SetLayoutFlags(myLabel, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(myButton, new Rectangle(0.20, 0.20, 0.25, 0.25));
            AbsoluteLayout.SetLayoutFlags(myButton, AbsoluteLayoutFlags.All);

            layout.Children.Add(myLabel);
            layout.Children.Add(myButton);

            Content = layout;


        }
    }
}
