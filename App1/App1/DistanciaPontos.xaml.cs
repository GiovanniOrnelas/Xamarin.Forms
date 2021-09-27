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
    public partial class DistanciaPontos : ContentPage
    {
        public DistanciaPontos()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            double Xa, Ya, Xb, Yb, distancia;
            string resposta = "";

            Xa = Convert.ToDouble(etValorXa.Text);
            Ya = Convert.ToDouble(etValorYa.Text);
            Xb = Convert.ToDouble(etValorXb.Text);
            Yb = Convert.ToDouble(etValorYb.Text);

            distancia = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));

            resposta = "A distância entre os dois pontos é de: " + Math.Round(distancia,2);

            lbResp.Text = resposta;
        }
    }
}