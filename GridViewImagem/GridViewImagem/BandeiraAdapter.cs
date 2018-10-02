using System.Collections.Generic;
using Android.Views;
using Android.Widget;
using Android.Content;

namespace GridViewImagem
{
    public class BandeiraAdapter : BaseAdapter
    {
        private Context ctx;
        private List<Bandeira> bandeiras;
        private LayoutInflater layinfla;

        public BandeiraAdapter(List<Bandeira> _bandeiras, Context c)
        {
            this.bandeiras = _bandeiras;
            this.ctx = c;
        }

        public override int Count
        {
            get
            {
                return bandeiras.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return bandeiras[position].Nome;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (layinfla == null)
            {
                layinfla = (LayoutInflater)ctx.GetSystemService(Context.LayoutInflaterService);
            }

            if (convertView == null)
            {
                convertView = layinfla.Inflate(Resource.Layout.Modelo, parent, false);
            }

            //vincula dados
            TextView txtNome = convertView.FindViewById<TextView>(Resource.Id.txtNome);
            ImageView Imagem = convertView.FindViewById<ImageView>(Resource.Id.bandeiraImg);

            txtNome.Text = bandeiras[position].Nome;
            Imagem.SetImageResource(bandeiras[position].Imagem);

            return convertView;
        }
    }
}