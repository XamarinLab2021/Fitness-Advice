using Android.App;
using Android.Content;
using Android.OS;
using System.Threading.Tasks;
using AndroidX.AppCompat.App;

namespace FitnessAdvice.Droid
{
    [Activity(Theme = "@style/MyTheme.SplashScreen", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
        }

        protected override void OnResume()
        {
            base.OnResume();
            var startupWork = new Task(DoWhatEverYouNeedAtStartup);
            
            startupWork.Start();
        }

        private async void DoWhatEverYouNeedAtStartup()
        {
            // as we have nothing to do at startup that would take some time, let us just simulate it
            await Task.Delay(500);
            // after the startup work is done, launch another activity
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}