using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);

            button1.Click += delegate{
                button1.SetBackgroundColor(Android.Graphics.Color.Red);
                button1.Text = string.Format("{0} clique(s)!",count++);
            };

            Button button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += delegate{
                button2.SetTextColor(Android.Graphics.Color.Black);
                button2.SetBackgroundColor(Android.Graphics.Color.Yellow);

                TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);

                for (int i=0;i<100;i++) {
                    textView1.Text=i.ToString();
                }

            };
        }
    }
}

