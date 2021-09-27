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
    public partial class AreaTriangulo : ContentPage
    {
        public AreaTriangulo()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            double l1, l2, l3, area, t;
            string resposta = "";

            l1 = Convert.ToDouble(etLado1.Text);
            l2 = Convert.ToDouble(etLado2.Text);
            l3 = Convert.ToDouble(etLado3.Text);

            t = (l1 + l2 + l3) / 2;

            area = Math.Sqrt(t * (t - l1) * (t - l2) * (t - l3));

            resposta = "A área do triângulo é de: " + Math.Round(area,2);

            lbResp.Text = resposta;
        }
    }
}