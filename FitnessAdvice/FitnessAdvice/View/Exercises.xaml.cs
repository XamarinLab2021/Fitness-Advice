using FitnessAdvice.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessAdvice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercises : ContentPage
    {
        public Exercises()
        {
            InitializeComponent();
        }

        private async void Frontcore_Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FrontCore(), true);
        }

        private async void Backcore_Btn_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MainPage(), true);
        }

        private async void Wholearms_Btn_Clicked(object sender, EventArgs e)
        {
        await Navigation.PushAsync(new ArmsPage(), true);
        }

        private async void Wholelegs_Btn_Clicked(object sender, EventArgs e)
        {
        await Navigation.PushAsync(new MainPage(), true);
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }
    }
}