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
    public partial class IMC : ContentPage
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            double peso, altura, IMC;
            string resposta = "";
            string respostaIMC = "";

            peso = Convert.ToDouble(etPeso.Text);
            altura = Convert.ToDouble(etAltura.Text);

            IMC = Math.Round(peso / Math.Pow(altura,2),1);

            respostaIMC += "IMC: " + IMC;
            lbRespIMC.Text = respostaIMC;

            if (IMC < 20)
            {
                resposta = "Abaixo do peso";
            }

            else if (IMC >= 20 || IMC < 25)
            {
                resposta = "Peso normal";
            }
            
            else if (IMC >= 25 || IMC < 30)
            {
                resposta = "Sobre peso";
            }
            
            else if (IMC >= 30 || IMC < 40)
            {
                resposta = "Obeso";
            }
            
            else if (IMC >= 40)
            {
                resposta = "Obeso Mórbido";
            }

            lbResp.Text = resposta;
        }
    }
}