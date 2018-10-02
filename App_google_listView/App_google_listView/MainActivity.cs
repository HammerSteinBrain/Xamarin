using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Views;
using Android.Content;

namespace App_google_listView
{
    [Activity(Label = "App_google_listView", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
    
        List<string> recursos;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //SetContentView(Resource.Layout.Main);

            CarregaLista();
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, recursos);

        }

        private void CarregaLista()
        {
            recursos = new List<string>();
            recursos.Add("Visual Basic");
            recursos.Add("VB .NET");
            recursos.Add("Visual C sharp");
            recursos.Add("JavaScript");
        }

        //sobrescrita do evento de click em um dos items da lista
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var item = recursos[position];//exibe o item escolhido no toast
            Toast.MakeText(this, item, ToastLength.Short).Show();

            //abrir o navegador

            //mescla o item com a uri de pesquisa do google
            var uri = Android.Net.Uri.Parse("https://www.google.com/#q="+item);

            //define uma intent e estarta a itenção (que é abrir a var uri)
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
    }
}

