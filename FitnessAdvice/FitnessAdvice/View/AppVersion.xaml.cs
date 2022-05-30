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
    public partial class AppVersion : ContentPage
    {
        public AppVersion()
        {
            InitializeComponent();
        }

        private  async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsBasic(), true);
        }
    }
}