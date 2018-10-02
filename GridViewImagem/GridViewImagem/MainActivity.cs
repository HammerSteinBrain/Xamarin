using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace GridViewImagem
{
    [Activity(Label = "GridViewImagem", MainLauncher = true,Icon ="@drawable/lion")]
    public class MainActivity : Activity
    {
        GridView gv;
        private BandeiraAdapter adapter;
        private List<Bandeira> bandeiras;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            gv = FindViewById<GridView>(Resource.Id.gvDados);
            adapter = new BandeiraAdapter(GetBandeiras(), this);
            gv.Adapter = adapter;

            gv.ItemClick += Gv_Click;
            //quando clicar em algum item da grid view
            //chama o metodo abaixo e envia o AdapterView.ItemClickEventArgs e
            //que é o nome da baindeira q foi definido em GetBandeiras()
        }

        private void Gv_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, bandeiras[e.Position].Nome,ToastLength.Short).Show();
        }

        private List<Bandeira> GetBandeiras() {

            bandeiras = new List<Bandeira>();
            Bandeira band;

            band = new Bandeira("Brasil", Resource.Drawable.br);
            bandeiras.Add(band);
            band = new Bandeira("França", Resource.Drawable.fr);
            bandeiras.Add(band);
            band = new Bandeira("India", Resource.Drawable.@in);
            bandeiras.Add(band);
            band = new Bandeira("Italia", Resource.Drawable.it);
            bandeiras.Add(band);
            band = new Bandeira("Japão", Resource.Drawable.jp);
            bandeiras.Add(band);
            band = new Bandeira("Mexico", Resource.Drawable.mx);
            bandeiras.Add(band);
            band = new Bandeira("USA", Resource.Drawable.us);
            bandeiras.Add(band);

            return bandeiras;
        }

    }
}

