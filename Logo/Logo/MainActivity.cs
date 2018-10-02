using Android.App;
using Android.Widget;
using Android.OS;

namespace Logo
{
    [Activity()]
    public class MainActivity : Activity
    {
        int count = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);

            button1.Click += delegate {
                button1.Text= string.Format("{0} cliques!",count++);
                button1.SetBackgroundColor(Android.Graphics.Color.BlueViolet);
            };
        }
    }
}

