using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FitnessAdvice
{
    public class SplashPage : ContentPage
    {
        public Image splashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Image splashImage = new Image
            {
                Source = "/Resources/drawable/startingscreen.png" //"startingscreen.png"
            };

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            System.Threading.Thread.Sleep(250);
            Application.Current.MainPage = new NavigationPage(new FirstAppears());
        }
    }
}