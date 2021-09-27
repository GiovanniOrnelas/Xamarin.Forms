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
    public partial class Fatorial : ContentPage
    {
        public Fatorial()
        {
            InitializeComponent();
        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
            int numeroFatorial, contador = 1, numeroConstante = 1;
            string resposta = "";
            
            numeroFatorial = Convert.ToInt32(etFatorial.Text);

            while (contador <= numeroFatorial)
            {
                numeroConstante *= contador;
                // 1            *      1 = 1
                // 1            *      2 = 2 
                // 2            *      3 = 6
                // 6            *      4 = 24 
                // 24            *     5 = 120 
                contador++;
            }
            resposta = numeroFatorial + "! = " + numeroConstante;
            lbResp.Text = resposta;
        }
    }
}