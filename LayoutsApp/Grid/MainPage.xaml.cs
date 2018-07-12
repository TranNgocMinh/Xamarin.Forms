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
            // create a new grid
            var grid = new Grid();
            // define one row
            grid.RowDefinitions.Add(new RowDefinition {  });
            //define two columns
            grid.ColumnDefinitions.Add(new ColumnDefinition { });
            grid.ColumnDefinitions.Add(new ColumnDefinition {  });
            var myLabel = new Label
            {
                Text = "I am a Label",
                Margin = 5,
               
            };
            var myButton = new Button
            {
                Text = "I am a Button",
                Margin = 5
            };
            //adding controls to grid
            // Grid.Row = 0 Grid.Column = 0
            grid.Children.Add(myLabel,0,0);
            // Grid.Row = 0 Grid.Column = 1
            grid.Children.Add(myButton,1,0);

            Content = grid;
            //InitializeComponent();

        }
        public MainPage()
		{
            // create a new grid
            var grid = new Grid();
            // define two rows
            grid.RowDefinitions.Add(new RowDefinition {  });
            grid.RowDefinitions.Add(new RowDefinition { });
            //define one column
            grid.ColumnDefinitions.Add(new ColumnDefinition { });

            var myLabel = new Label
            {
                Text = "I am a Label",
                Margin = 5,
               
            };
            var myButton = new Button
            {
                Text = "I am a Button",
                Margin = 5
            };
            //adding controls to grid
            
            // Grid.Row = 0 Grid.Column = 0
            grid.Children.Add(myLabel,0,0);
            // Grid.Row = 1 Grid.Column = 0
            grid.Children.Add(myButton,0,1);

            Content = grid;
            //InitializeComponent();


        }
    }
}
