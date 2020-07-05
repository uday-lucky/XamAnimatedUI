using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinUserLogin.views;

namespace XamarinUserLogin.views
{
    public partial class HomePage :ContentPage
    {
    
        public bool ImageAnimate = false;
        public HomePage()
        {
            InitializeComponent();
            myGrd.WidthRequest = 350;

        }

        async void SignUptapped(System.Object sender, System.EventArgs e)
        {
            logingrid.RaiseChild(loginbtn);
            hideProfileImageandName();
            await Task.WhenAny<bool>
            (
             ProfileGrid.LayoutTo(new Rectangle(ProfileGrid.Bounds.X, ProfileGrid.Bounds.Y, 0, ProfileGrid.Height), 0, easing: Easing.Linear),
             ProfileGrid.FadeTo(0.2, 1000, easing: Easing.SinOut),

             loginbtn.TranslateTo(loginbtn.TranslationX -30, loginbtn.TranslationY , 1000, easing: Easing.Linear),
             signUpbutton.TranslateTo(signUpbutton.TranslationX+30, loginbtn.TranslationY, 1000, easing: Easing.Linear),
            //loginbtn.TranslateTo(loginbtn.TranslationX - 45, loginbtn.TranslationY + 15, 2000, easing: Easing.Linear),
            myGrd.FadeTo(0.2, 1000, easing: Easing.SinOut),
            myGrd.FadeTo(1, 1000, easing: Easing.SinOut),
            myGrd.LayoutTo(new Rectangle(myGrd.Bounds.X, myGrd.Bounds.Y, 350, myGrd.Height),1000,easing:Easing.Linear)
            ); 
         
        }


        async void loginTapped(System.Object sender, System.EventArgs e)
        {
            logingrid.RaiseChild(signUpbutton);
            hideProfileImageandName();
           

            await Task.WhenAny<bool>
            (
                 myGrd.LayoutTo(new Rectangle(myGrd.Bounds.X, myGrd.Bounds.Y, 0, myGrd.Height), 1000, easing: Easing.Linear),
             myGrd.FadeTo(0.2, 100, easing: Easing.SinOut),
          
            
            loginbtn.TranslateTo(loginbtn.TranslationX + 30, loginbtn.TranslationY, 1000, easing: Easing.Linear),
            signUpbutton.TranslateTo(signUpbutton.TranslationX - 30, signUpbutton.TranslationY, 1000, easing: Easing.Linear),
            ProfileGrid.FadeTo(0.2, 1000, easing: Easing.SinOut)
           
            //loginbtn.TranslateTo(loginbtn.TranslationX +45, loginbtn.TranslationY - 15, 2000, easing: Easing.Linear),
            //signUpbutton.TranslateTo(signUpbutton.TranslationX - 45, signUpbutton.TranslationY + 15, 2000, easing: Easing.Linear),


            );
            await Task.Delay(750);
            await Task.WhenAny<bool>(
              ProfileGrid.FadeTo(1, 1000, easing: Easing.SinOut),
         ProfileGrid.LayoutTo(new Rectangle(ProfileGrid.Bounds.X, ProfileGrid.Bounds.Y, 350, ProfileGrid.Height), 1000, easing: Easing.Linear)
             );

        }

        public  void Entry_Completed(object sender, EventArgs e)
        {
            if (((Entry)sender).Text.ToUpper() == "UDAY" )
            {
                if (ImageAnimate == false)
                {
                    //ShowProfileImageandName();
                    translateImage();
                    ImageAnimate = true;
                }
            }
            else
            {
                if (ImageAnimate == true)
                {
                   // hideProfileImageandName();
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
            profileImage.TranslateTo(0, profileImage.TranslationY + 30, 500, easing: Easing.CubicIn),
            myGrd.LayoutTo(new Rectangle(myGrd.Bounds.X, myGrd.Bounds.Y, 350, myGrd.Height), 2000, easing: Easing.Linear)

            );
        }

        public async void undotranslateImage()
        {
            await Task.WhenAny<bool>
            (
            userName.TranslateTo(userName.TranslationX - 100, 0, 500, easing: Easing.CubicIn),
            profileImage.TranslateTo(0, profileImage.TranslationY - 30, 500, easing: Easing.CubicIn),
            myGrd.LayoutTo(new Rectangle(myGrd.Bounds.X, myGrd.Bounds.Y, 350, myGrd.Height), 2000, easing: Easing.Linear)

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
