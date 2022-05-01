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
    public partial class TricepBW : ContentPage
    {
        public ObservableCollection<Exercise> Tricepcirses { get; set; }
        public TricepBW()
        {
            InitializeComponent();

            Tricepcirses = new ObservableCollection<Exercise>
            {
                new Exercise { Name = "Bench dip", Type = "Push", Image = "TricepIcon.jpg"}

        };
            lstview.ItemsSource = Tricepcirses;
        }

        private async void Bench_Dip_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BenchDip(), true);
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArmsPartSelection_BW(), true);
        }
    }
}