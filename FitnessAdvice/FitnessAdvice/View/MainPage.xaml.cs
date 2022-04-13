using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;

namespace FitnessAdvice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises(), true);
        }
        public async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsBasic(), true);
        }
        public async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Meal(), true);
        }
    }
}