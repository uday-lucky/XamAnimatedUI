using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUserLogin.views;


namespace XamarinUserLogin
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental" });
            InitializeComponent();

            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {

        }
    }
}
