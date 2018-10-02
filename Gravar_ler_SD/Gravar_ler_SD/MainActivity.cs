using Android.App;
using Android.Widget;
using Android.OS;

namespace Gravar_ler_SD
{
    [Activity(Label = "Gravar_ler_SD", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btnLer = FindViewById<Button>(Resource.Id.btnLer);
            TextView txtAcao = FindViewById<TextView>(Resource.Id.txtAcao);

            EscreverArquivoTexto();

            btnLer.Click += delegate {//faz a leitura do texto e coloca ele no txtAcao

                var sdPath = Android.OS.Environment.ExternalStorageDirectory.Path;
                //salvando caminho do SD card na variavel sdPath
                var arquivoPath = System.IO.Path.Combine(sdPath, "ArquivoSD.txt");
                //combinando o caminho com o nome do arquivo q sera gerado e salvando
                //em path o arquivo em branco

                if (System.IO.File.Exists(arquivoPath)){//se existir o arquivo la no caminho
                    var texto = System.IO.File.ReadAllText(arquivoPath);
                    //ler o texto que se encontra no arquivo salvo em arquivoPath
                    txtAcao.Text = texto; //atribui o texto lido ao txtAcao
                    Toast.MakeText(this, "Arquivo lido com sucesso", ToastLength.Short).Show();
                }
                else
                {
                    Toast.MakeText(this, "Arquivo " + arquivoPath.ToString() + " Não encontrado!", ToastLength.Short).Show();
                }

            };

        }

        private void EscreverArquivoTexto() {//Gera e escreve o arquivo

            var sdPath = Android.OS.Environment.ExternalStorageDirectory.Path;
            //salvando caminho do SD card na variavel sdPath
            var arquivoPath = System.IO.Path.Combine(sdPath,"ArquivoSD.txt");
            //combinando o caminho com o nome do arquivo q sera gerado e salvando
            //em path o arquivo em branco

            if (!System.IO.File.Exists(arquivoPath)){//se NÃO existir o arquivo la no caminho
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(arquivoPath,true)) {
                    //instancia o StreamWriter como writer para escrever em arquivoPath
                    //pq la vai ser gerado o ArquivoSD.txt
                    writer.Write("Rodrigo .NET");//Escreve algo
                    Toast.MakeText(this,"Arquivo gravado com sucesso!",ToastLength.Short).Show();
                }
            }
            else{
                Toast.MakeText(this,"Arquivo "+arquivoPath.ToString()+" ja existe!",ToastLength.Short).Show();
            }

        }
    }
}

