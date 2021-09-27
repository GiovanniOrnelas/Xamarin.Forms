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
    public partial class Equacao : ContentPage
    {
        public Equacao()
        {
            InitializeComponent();
        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
            double A, B, C, D, X1, X2;
            string resposta = "";

            A = Convert.ToDouble(etA.Text);

            B = Convert.ToDouble(etB.Text);

            C = Convert.ToDouble(etC.Text);

            D = Math.Pow(B, 2) - 4 * A * C;

            if (D < 0)
            {
                resposta = "Não existe raiz real";
            }

            else if (D > 0)
            {
                X1 = (-B + Math.Sqrt(D)) / 2 * A;
                X2 = (-B - Math.Sqrt(D)) / 2 * A;
                resposta = "Existe duas raizes reais, sendo a primeira ( " + X1 + " ) e a segunda ( " + X2 + " )";
            }

            else
            {
                resposta = "Existe uma raiz real";
                X1 = -B / (2 * A);
                resposta += "\nSendo ela ( " + X1 + " )";
            }

            lbResp.Text = resposta;
        }
    }
}