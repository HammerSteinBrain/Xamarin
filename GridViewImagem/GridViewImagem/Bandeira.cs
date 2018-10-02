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

namespace GridViewImagem
{
    //classe responsavel por idenficar e registrar as imagens no construtor
    //serve para facilitar a manipulação das imagens, ja q são muitas

    public class Bandeira
    {
        public Bandeira(string _nome, int _imagem)
        {
            this.Nome = _nome;
            this.Imagem = _imagem;
        }

        public string Nome { get; set; }
        public int Imagem { get; set; }//pega o id numero da imagem q foi gerado em resource

    }
}