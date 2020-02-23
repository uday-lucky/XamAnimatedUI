using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinUserLogin.views;

namespace XamarinUserLogin.Templates
{
    public partial class SignUpView : ContentView
    {
        public double _pageheight;
        public bool ImageAnimate = false;
        public SignUpView()
        {
            InitializeComponent();
          
        }

       async void SignUptapped(System.Object sender, System.EventArgs e)
        {
            hideProfileImageandName();
            await Task.WhenAny<bool>
            (
              ProfileGrid.FadeTo(0.2, 2000, easing: Easing.SinOut),
             loginbtn2.TranslateTo(loginbtn2.TranslationX - 45, loginbtn2.TranslationY+15, 2000, easing: Easing.Linear),
             signUpbutton.TranslateTo(signUpbutton.TranslationX + 45, signUpbutton.TranslationY - 15, 2000, easing: Easing.Linear),
             signUpbutton2.TranslateTo(signUpbutton2.TranslationX + 45, signUpbutton2.TranslationY - 15, 2000, easing: Easing.Linear),
             loginbtn.TranslateTo(loginbtn.TranslationX - 45, loginbtn.TranslationY+15, 2000, easing: Easing.Linear),
             myGrd.FadeTo(0.2, 2000, easing: Easing.SinOut),
             myGrd.FadeTo(1, 2000, easing: Easing.SinOut)
            
             ); 
            signupGrid.IsVisible = false;
            logingrid.IsVisible = true;
            myGrd.IsVisible = true;
            ProfileGrid.IsVisible = false;
        }


        async void loginTapped(System.Object sender, System.EventArgs e)
        {
            hideProfileImageandName();
            await Task.WhenAny<bool>
            (
             myGrd.FadeTo(0.2, 2000, easing: Easing.SinOut),
             signUpbutton2.TranslateTo(signUpbutton2.TranslationX - 45, signUpbutton2.TranslationY+15, 2000, easing: Easing.Linear),
             loginbtn2.TranslateTo(loginbtn2.TranslationX +45, loginbtn2.TranslationY-15 , 2000, easing: Easing.Linear),
             loginbtn.TranslateTo(loginbtn.TranslationX +45, loginbtn.TranslationY - 15, 2000, easing: Easing.Linear),
             signUpbutton.TranslateTo(signUpbutton.TranslationX - 45, signUpbutton.TranslationY + 15, 2000, easing: Easing.Linear),
             ProfileGrid.FadeTo(0.2, 2000, easing: Easing.SinOut),
             ProfileGrid.FadeTo(1, 2000, easing: Easing.SinOut)
            
            );
            
           
            logingrid.IsVisible = false;
            signupGrid.IsVisible = true;
            myGrd.IsVisible = false;
            ProfileGrid.IsVisible = true;
        }
        protected override void OnSizeAllocated(double width, double height)
        {
           
            base.OnSizeAllocated(width, height);
        }

        public async void Entry_Completed(object sender, EventArgs e)
        {            if (((Entry)sender).Text.ToUpper() == "UDAY" )
            {
                if (ImageAnimate == false)
                {
                    ShowProfileImageandName();
                    translateImage();
                    ImageAnimate = true;
                }
            }
            else
            {
                if (ImageAnimate == true)
                {

                    hideProfileImageandName();
                    undotranslateImage();
                    ImageAnimate = false;

                   
                }
            }

        }

        public async void OnLoginSuccess(object sender,EventArgs e)
        {
            
        }

        public async void translateImage()
        {
            await Task.WhenAny<bool>
            (
            userName.TranslateTo(userName.TranslationX + 100, 0, 500, easing: Easing.CubicIn),
            profileImage.TranslateTo(0, profileImage.TranslationY + 30, 500, easing: Easing.CubicIn)
            );
        }
        public async void undotranslateImage()
        {
            await Task.WhenAny<bool>
            (
            userName.TranslateTo(userName.TranslationX - 100, 0, 500, easing: Easing.CubicIn),
            profileImage.TranslateTo(0, profileImage.TranslationY - 30, 500, easing: Easing.CubicIn)
            );
        }

        public void ShowProfileImageandName()
        {
            profileImage.IsVisible = true;
            userName.IsVisible = true;
        }
        public void hideProfileImageandName()
        {
            profileImage.IsVisible = false;
            userName.IsVisible = false;
        }

    }
}
