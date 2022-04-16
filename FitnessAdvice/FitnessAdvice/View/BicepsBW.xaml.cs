using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessAdvice.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BicepsBW : ContentPage
    {
        public ObservableCollection<Exercise> Bicepcirses { get; set; }
        public BicepsBW()
        {
            InitializeComponent();

            Bicepcirses = new ObservableCollection<Exercise>
            {
                new Exercise { Name = "Bicep towel curl", Type = "Isolation", Image = "BicepIcon.png"}

        };
            lstView.ItemsSource = Bicepcirses;
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArmsPartSelection_BW(), true);
        }

        private async void Bicep_Curl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BicepTowelCurl(), true);//nastavit na ukazkovu page alebo okno s ukazkou cviku
        }
    }
}