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
    public partial class Comerciante : ContentPage
    {
        public Comerciante()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            double venda, lucro, ganhoTotal;
            string resposta = "";

            venda = Convert.ToDouble(etCompra.Text);

            if (venda < 10)
            {
                lucro = venda * 0.70;              
            }
            
            else if (venda < 30)
            {
                lucro = venda * 0.50;
            }
            
            else if (venda < 50)
            {
                lucro = venda * 0.40;
            }
            
            else 
            {
                lucro = venda * 0.30;             
            }

            ganhoTotal = venda + lucro;
            resposta = "O seu lucro é de: R$" + Math.Round(lucro, 2);
            resposta += "\nO valor do recibo total é de: R$" + ganhoTotal;

            lbResp.Text = resposta;

        }
    }
}