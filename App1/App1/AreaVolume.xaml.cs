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
    public partial class AreaVolume : ContentPage
    {
        public AreaVolume()
        {
            InitializeComponent();
        }

        private void btExecutar_Clicked(object sender, EventArgs e)
        {
            double altura, raio, volume, area;
            string resposta = "";

            altura = Convert.ToDouble(etRaio.Text);
            raio = Convert.ToDouble(etAltura.Text);

            area = (2 * Math.PI * raio * altura) + raio;
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            resposta = "Área do Cilindro = " + Math.Round(area,2);
            resposta += "\nVolume do Cilindro = " + Math.Round(volume,2);

            lbResp.Text = resposta;
        }
    }
}