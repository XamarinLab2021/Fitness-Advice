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
    public partial class SettingsBasic : ContentPage
    {
        public SettingsBasic()
        {
            InitializeComponent();
        }
       
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }

        private void UR_BW_Completed(object sender, EventArgs e)
        {
          //setter alebo ine...
        }

        private async void AppVersion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppVersion(), true);
        }
    }
}