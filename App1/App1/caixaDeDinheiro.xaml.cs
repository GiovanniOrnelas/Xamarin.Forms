using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class caixaDeDinheiro : ContentPage
    {
        public caixaDeDinheiro()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            int dinheiro, troco200, troco100, troco50, troco20, troco10, troco5, troco2, troco1;
            string resposta = "";

            dinheiro = Convert.ToInt32(etTroco.Text);

            resposta = dinheiro + " reais em troco é:";

            troco200 = dinheiro / 200;
            dinheiro = dinheiro % 200;
            troco100 = dinheiro / 100;
            dinheiro = dinheiro % 100;
            troco50 = dinheiro / 50;
            dinheiro = dinheiro % 50;
            troco20 = dinheiro / 20;
            dinheiro = dinheiro % 20;
            troco10 = dinheiro / 10;
            dinheiro = dinheiro % 10;
            troco5 = dinheiro / 5;
            dinheiro = dinheiro % 5;
            troco2 = dinheiro / 2;
            dinheiro = troco2 % 2;
            troco1 = dinheiro;


            resposta += "\n" + troco200 + " notas de 200";
            resposta += ", " + troco100 + " notas de 100";
            resposta += ", " + troco50 + " notas de 50";
            resposta += ", " + troco20 + " notas de 20";
            resposta += ", " + troco10 + " notas de 10";
            resposta += ", " + troco5 + " notas de 5";
            resposta += ", " + troco2 + " notas de 2";
            resposta += ", " + troco1 + " moedas de 1";

            lbResp.Text = resposta;

        }
    }
}