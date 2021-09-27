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
    public partial class Divisel : ContentPage
    {
        public Divisel()
        {
            InitializeComponent();
        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
            double A, B, totalDaDivisao;
            string resposta = "";

            A = Convert.ToDouble(etValorA.Text);
            B = Convert.ToDouble(etValorB.Text);      
             

            if (B != 0)
            {
                totalDaDivisao = A / B;
                resposta = "O valor da divisão é de: " + totalDaDivisao;
            }

            else
            {
                resposta = "Valor B não pode ser 0!!!";
            }

            lbResp.Text = resposta;
        }
    }
}