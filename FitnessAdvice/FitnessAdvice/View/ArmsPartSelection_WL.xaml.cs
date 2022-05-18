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
    public partial class ArmsPartSelection_WL : ContentPage
    {
        public ArmsPartSelection_WL()
        {
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArmsPage(), true);
        }

        private async void Biceps_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BicepsWL(), true);
        }

        private void Triceps_Clicked(object sender, EventArgs e)
        {

        }

        private void Shoulders_Clicked(object sender, EventArgs e)
        {

        }

        private void Forearms_Clicked(object sender, EventArgs e)
        {

        }
    }
}