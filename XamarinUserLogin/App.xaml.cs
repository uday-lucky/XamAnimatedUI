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
            InitializeComponent();

            MainPage = new UserPage();
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
