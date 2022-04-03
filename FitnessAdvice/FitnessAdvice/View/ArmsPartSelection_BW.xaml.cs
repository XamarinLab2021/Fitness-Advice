using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessAdvice.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArmsPartSelection_BW : ContentPage
    {
        public ArmsPartSelection_BW()
        {
            InitializeComponent();
        }

        private async void Back_Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }

        private async void Triceps_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }

        private async void Biceps_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BicepsBW(), true);
        }

        private async void Shoulders_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }

        private async void Forearms_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }
    }
}