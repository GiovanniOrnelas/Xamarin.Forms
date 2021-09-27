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
    public partial class Quadrante : ContentPage
    {
        public Quadrante()
        {
            InitializeComponent();
        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
            double X, Y;
            string resposta = "";
           
            Y = Convert.ToDouble(etY.Text);
            X = Convert.ToDouble(etX.Text);
            

            if (X > 0 && Y > 0)
            {
                resposta = "1º Quadrante";
            }

            else if (X < 0 && Y > 0)
            {
                resposta = "2º Quadrante";
            }

            else if (X < 0 && Y < 0)
            {
                resposta = "3º Quadrante";
            }

            else if (X > 0 && Y < 0)
            {
                resposta = "4º Quadrante";
            }

            else 
            {
                resposta = "Os pontos estão na origem";
            }

            lbResp.Text = resposta;
        }
    }
}