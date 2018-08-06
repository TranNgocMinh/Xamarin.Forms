namespace NavigApp
{
       [XamlCompilation(XamlCompilationOptions.Compile)]
       public partial class SecondPage : ContentPage
       {
              public SecondPage ()
              {
                     InitializeComponent ();
              }
              async private void prevPage(object sender, EventArgs e)
              {
                    await Navigation.PopAsync();
              }
       }
}
