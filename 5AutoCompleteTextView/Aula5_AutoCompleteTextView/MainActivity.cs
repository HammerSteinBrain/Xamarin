using Android.App;
using Android.Widget;
using Android.OS;

namespace Aula5_AutoCompleteTextView
{
    [Activity(Label = "Aula5_AutoCompleteTextView", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            string[] estados = new string[] { "Amazonas","Alagoas","Amapa","Santa Catarina",
            "Sergipe","São Paulo","Roraima","Rio de Janeiro","Rio Grande do Sul",
            "Minas Gerais","Mato Grosso"};

            AutoCompleteTextView autoCompletar1 = FindViewById<AutoCompleteTextView>
                (Resource.Id.autoCompleteTextView1);
            //instancia do autoCompleteTextView1 q vc colou la no main xml
            //e ele é do tipo AutoCompleteTextView q é uma classe la de System

            autoCompletar1.Threshold = 2; //n de caracteres q ele busca no array

            Button btnEnviar = FindViewById<Button>(Resource.Id.btnEnviar);

            ArrayAdapter adapter = new ArrayAdapter<string>
                (this, Android.Resource.Layout.SimpleListItem1, estados);
            //adapta o array de estados ao layout 'SimpleListItem1' e salva em adapter

            autoCompletar1.Adapter = adapter; //mescla o adapter com a instancia do item autoCompletar1

            btnEnviar.Click += delegate {
                if (autoCompletar1.Text != ""){
                    Toast.MakeText(this, " Estado = " + autoCompletar1.Text, ToastLength.Short).Show();
                }
                else{//caso o campo estado esteja vazio
                    Toast.MakeText(this, " Informe o nome do Estado:" + autoCompletar1.Text, ToastLength.Short).Show();
                }
            };

        }
    }
}

