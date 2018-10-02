using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections;

namespace App_DemoGriView
{
    [Activity(Label = "App_DemoGriView", MainLauncher = true, Icon ="@drawable/lion")]
    public class MainActivity : Activity
    {

        //Variaveis GLOBAIS
        GridView gv;
        ArrayList lista;
        ArrayAdapter adpt;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            gv = FindViewById<GridView>(Resource.Id.gdvDados);

            Dados();

            adpt = new ArrayAdapter(this,Android.Resource.Layout.SimpleListItem1,lista);
            //cria uma text view para cada item do arrayList

            gv.Adapter = adpt; //atribui o adapter padrão do gv ao adapter que criamos adpt

            gv.ItemClick += Gv_ItemClick;
        }

        private void Gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this,lista[e.Position].ToString(),ToastLength.Short).Show();
        }

        private void Dados() {

            lista = new ArrayList();

            lista.Add("Leaozinho");
            lista.Add("Liaum");
            lista.Add("baby Liaum");
            lista.Add("Moranguinho");
            lista.Add("Pudin de Galak");
            lista.Add("Docinho");
            lista.Add("Liaum Bravo");
            lista.Add("Baby Liaum Pink");
            lista.Add("Gisele Lobinho");

        }

    }
}

