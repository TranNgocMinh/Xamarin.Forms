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
            var layout = new RelativeLayout();

            var myLabel = new Label
            {
                Text = "I am a Label",
                Margin = 5,
                BackgroundColor = Color.Blue
            };
            var myButton = new Button
            {
                Text = "I am a Button",
                Margin = 5,
                BackgroundColor = Color.Red
            };
            //adding controls to RelativeLayout


            layout.Children.Add(myLabel, Constraint.RelativeToParent((parent) => {
                return parent.X;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Y * .15;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Width;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Height * .8;
            }));

            layout.Children.Add(myButton, Constraint.RelativeToView(myLabel, (Parent, sibling) => {
                 return sibling.X + 20;
             }), Constraint.RelativeToView(myLabel, (parent, sibling) => {
                 return sibling.Y + 20;
             }), Constraint.RelativeToParent((parent) => {
                 return parent.Width * .5;
             }), Constraint.RelativeToParent((parent) => {
                 return parent.Height * .5;
             }));
           

            Content = layout;



        }
    }
}
