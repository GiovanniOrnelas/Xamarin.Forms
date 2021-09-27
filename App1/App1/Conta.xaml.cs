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
    public partial class Conta : ContentPage
    {
        public Conta()
        {
            InitializeComponent();
        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
            double numero,soma = 0, contador = 1, n =0;
            string resposta = "";

            n = Convert.ToDouble(etNumero.Text);
            numero = n;
            while (contador <= numero)
            {
                soma += contador / n;
                contador++;
                n--;
            }
            resposta +="\nA resposta é de: " + soma.ToString();

            lbResp.Text = resposta;
        }
    }
}