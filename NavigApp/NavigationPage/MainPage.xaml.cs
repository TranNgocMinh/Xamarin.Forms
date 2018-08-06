namespace NavigApp
{
    public partial class MainPage : ContentPage
    {
       public  MainPage()
       {
             InitializeComponent();                            
        }
        async private void nextPage(object sender, EventArgs e)
        {
         await Navigation.PushAsync(new SecondPage());
        }

    }
}
