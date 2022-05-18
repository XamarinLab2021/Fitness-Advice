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
    public partial class BicepsWL : ContentPage
    {
        public ObservableCollection<Exercise> Bicepcirses { get; set; }
        public BicepsWL()
        {
            InitializeComponent();

            Bicepcirses = new ObservableCollection<Exercise>
            {
                new Exercise { Name = "Dumbbell Bicep Curl", Type = "Isolation", Image = "BicepIcon.png"}

        };
            lstView.ItemsSource = Bicepcirses;
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArmsPartSelection_WL(), true);
        }

        private async void Bicep_Curl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dumbbell_Bicep_Curl(), true);
        }
    }
}