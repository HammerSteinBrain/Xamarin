using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading;

namespace Logo
{
    [Activity(Theme ="@style/lion.Theme",MainLauncher =true, NoHistory =true)]
    //no history impede que o usuario volte pra essa tela

    public class Apresentacao : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Thread.Sleep(4000);
            StartActivity(typeof(MainActivity));
            
        }
    }
}