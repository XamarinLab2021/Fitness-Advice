using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FitnessAdvice
{
    public class Splashscreen : ContentPage 
    {
        Image splashscreenImage;
        public Splashscreen()
        {
            splashscreenImage = new Image()
            {
                Source = "starting-screen.png"
            };
        }
    }
}
