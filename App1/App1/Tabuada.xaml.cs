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
    public partial class Tabuada : ContentPage
    {
        public Tabuada()
        {
            InitializeComponent();
        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
            int numero, contador = 1, resultado;
            string resposta = "";

            numero = Convert.ToInt32(etNumeroTabuada.Text);

            while (contador <= 10)
            {
                resultado = numero * contador;
                resposta += "\n" + numero + " X " + contador + " = " + resultado;
                contador++;
            }

            lbResp.Text = resposta;
        }
    }
}