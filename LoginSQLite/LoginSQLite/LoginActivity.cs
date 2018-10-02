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

namespace LoginSQLite
{
    [Activity(Label = "LoginActivity", Icon = "@drawable/icon")]
    public class LoginActivity : Activity
    {
        TextView txtTextoLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);
            txtTextoLogin = FindViewById<TextView>(Resource.Id.txtTextoLogin);

            //pega os dados obtidos na primeira atividade e exibe no TextField

            //GetStringExtra - retorna os dados estendidos la da intent atividade2
            FindViewById<TextView>(Resource.Id.txtTextoLogin).Text =
                txtTextoLogin.Text+" : "+Intent.GetStringExtra("nome") ?? "Erro ao obter os dados";

        }
    }
}