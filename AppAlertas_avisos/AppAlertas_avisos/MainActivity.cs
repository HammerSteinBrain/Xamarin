using Android.App;
using Android.Widget;
using Android.OS;

namespace AppAlertas_avisos
{
    [Activity(Label = "AppAlertas_avisos", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);

            button1.Click += delegate {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);

                AlertDialog alerta = builder.Create();
                //definir o titulo, o icone, a mensagem e os botoes

                alerta.SetTitle("Rodrigo .net - Deseja continuar?");
                alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);
                alerta.SetMessage("Rodrigo .net - Quase tudo para .NET");

                alerta.SetButton("OK", (s, ev) =>
                {
                    Toast.MakeText(this, "Legal, vms continuar...", ToastLength.Short).Show();
                });
                alerta.Show();

            };

            Button button2 = FindViewById<Button>(Resource.Id.btnAlerta3);

            button2.Click += delegate {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);

                AlertDialog alerta = builder.Create();

                alerta.SetCancelable(true);
                alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);
                //define a mensagem
                alerta.SetMessage("Rodrigo .net - Amo .NET");
                //define os 3 botões
                alerta.SetButton("SIM", (s, ev) =>
                {
                    Toast.MakeText(this, "SIM!", ToastLength.Short).Show();
                });
                alerta.SetButton2("NÃO", (s, ev) =>
                {
                    Toast.MakeText(this, "NÃO!", ToastLength.Short).Show();
                });
                alerta.SetButton3("CANCELAR", (s, ev) =>
                {
                    Toast.MakeText(this, "CANCELAR!", ToastLength.Short).Show();
                });
                alerta.Show();
            };
        }
    }
}

