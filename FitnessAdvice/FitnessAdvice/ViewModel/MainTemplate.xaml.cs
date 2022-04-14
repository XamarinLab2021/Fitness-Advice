
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessAdvice.ViewModel
{
    [ContentProperty("Neviem")]
    public partial class MainTemplate : ContentView
    {
        public MainTemplate()
        {
            InitializeComponent();
        }
        public Xamarin.Forms.View Header
        {
            get => HeaderFrame.Content;
            set => HeaderFrame.Content = value;
        }
        public Xamarin.Forms.View Body
        {
            get => BodyContent.Content;
            set => BodyContent.Content = value;
        }
        public Xamarin.Forms.View Footer
        {
            get => FooterFrame.Content;
            set => FooterFrame.Content = value;
        }
    }
}