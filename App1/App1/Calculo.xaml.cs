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
    public partial class Calculo : ContentPage
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
            double numero, valorConstante = 1, soma = 0, contador = 1;
            string resposta = "";

            numero = Convert.ToDouble(etNumero.Text);

            while (contador <= numero)
            {
                soma += valorConstante / contador;
                contador++;
            }
           
            resposta += soma;
            
            lbResp.Text = resposta;      
        }
    }
}