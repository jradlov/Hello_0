using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Hello_0
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        bool clicked = true;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate {
                if (clicked) {
                    button.SetBackgroundColor(new Android.Graphics.Color(255, 55, 55));
                }
                else {
                    button.SetBackgroundColor(new Android.Graphics.Color(55, 55, 255));
                }

                clicked = !clicked;
            };

            Button button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += delegate {

            };

        }
    }
}

