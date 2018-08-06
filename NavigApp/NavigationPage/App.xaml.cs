namespace NavigApp
{
       public partial class App : Application
       {
              public App ()
              {
                     InitializeComponent();
                     //MainPage = new NavigApp.MainPage();
                     MainPage = new NavigationPage(new MainPage());
              }
...
}
