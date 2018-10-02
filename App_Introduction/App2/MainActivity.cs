using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);

            LinearLayout layout = new LinearLayout(this);

            layout.SetBackgroundColor(Android.Graphics.Color.Gray);

            layout.Orientation = Orientation.Vertical;

            Button button = new Button(this);

            button.Text = "Rodrigo";

            button.SetBackgroundColor(Android.Graphics.Color.Red);

            layout.AddView(button, ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

            SetContentView(layout);

        }
    }
}

