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
    public partial class ArmsPage : ContentPage
    {
        public ArmsPage()
        {
            InitializeComponent();
        }
        private async void BodyWeight_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArmsPartSelection_BW(), true);
        }

        private async void Weight_Lifting_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArmsPartSelection_WL(), true);
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises(), true);

        }
    }
}