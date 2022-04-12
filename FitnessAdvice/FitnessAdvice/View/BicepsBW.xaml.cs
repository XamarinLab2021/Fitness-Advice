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

        private void Back_Btn_Clicked(object sender, EventArgs e)
        {

        }
        public ObservableCollection<Exercise> Bicepcirses { get; set; }
        public BicepsBW()
        {
            InitializeComponent();

            Bicepcirses = new ObservableCollection<Exercise>
            {
                new Exercise { Name = "Towel Bicep Curl (1 leg)", Type = "Isolation", }//Image = "BicepCurl.png"
            };
            ///Bicepcirses.Add(new Exercise { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
            ///Bicepcirses.Add(new Exercise { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
            lstView.ItemsSource = Bicepcirses;
        }
    }
}