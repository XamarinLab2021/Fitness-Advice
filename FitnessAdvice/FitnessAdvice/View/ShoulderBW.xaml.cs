using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessAdvice.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoulderBW : ContentView
    {
        public ObservableCollection<Exercise> Shouldercirses { get; set; }
        public ShoulderBW()
        {
            InitializeComponent();
            Shouldercirses = new ObservableCollection<Exercise>
            {
                new Exercise { Name = "Elevated Pike PU", Type = "Push", Image = "ShouldersIcon.jfif"}

        };
            lstview.ItemsSource = Shouldercirses;
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArmsPartSelection_BW(), true);
        }

        private async void Elevated_PikeP_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ElevatedPikePU(), true);
        }
    }
}