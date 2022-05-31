using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FitnessAdvice.ViewModel;
using FitnessAdvice.View;

namespace FitnessAdvice.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();

            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += async (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
                await Navigation.PushAsync(new MainPage(), true);
                {
                    this.BindingContext = vm;
                   Action displaySuccessfulLogin = vm.DisplaySuccessfulLogin += () => DisplayAlert("Congratulations", "You have been signed in", "OK");
                };
            };
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsBasic(), true);
        }
    }
}