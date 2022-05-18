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
    public partial class ForeArmsBW : ContentPage
    {
        public ObservableCollection<Exercise> Tricepcirses { get; set; }
        public ForeArmsBW()
        {
            InitializeComponent();

            Tricepcirses = new ObservableCollection<Exercise>
            {
                new Exercise { Name = "Isometric wall push", Type = "Push", Image = "forearm_icon.png"}

        };
            lstview.ItemsSource = Tricepcirses;
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArmsPartSelection_BW(), true);
        }

        private async void Isometric_wall_push_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IsometricWallPush(), true);
        }
    }
}