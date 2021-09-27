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
    public partial class AnosMesesDias : ContentPage
    {
        public AnosMesesDias()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            int  dias, meses, anos, diasVividos;
            string resposta = "";

            anos = Convert.ToInt32(etIdade.Text);
            meses = Convert.ToInt32(etMeses.Text);
            dias = Convert.ToInt32(etDias.Text);


            anos*= 365;
            meses *= 30;
            dias *= 1;

            diasVividos = anos + meses + dias;

            resposta = "Você viveu " + diasVividos + " dias";

            lbResp.Text = resposta;
           
        }
    }
}