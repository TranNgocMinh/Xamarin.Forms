using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlsApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var name = this.FindByName<Entry>("name");
            var email = this.FindByName<Entry>("email");
            var age = this.FindByName<Slider>("age");
            var sex = this.FindByName<Switch>("sex");
            var birthday = this.FindByName<DatePicker>("birthday");

            string mySex = "";

            if (sex.IsToggled)
                mySex = "Male";
            else
                mySex = "Female";

            string message = "I am " + name.Text
                            + "\nMy Email is " + email.Text
                            + "\nMy age is " + age.Value.ToString()
                            + "\nMy sex is " + mySex
                            + "\nMy birthday is " + birthday.Date.ToShortDateString();

            DisplayAlert("Hello", message, "Cancel");
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();       
        }
    }
}
