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
    public partial class Garrafas : ContentPage
    {
        public Garrafas()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            int qntdeCervejas, engradados, sobra;
            string resposta = "";

            qntdeCervejas = Convert.ToInt32(etQuantidadeCervejas.Text);

            engradados = qntdeCervejas / 24;
            sobra = qntdeCervejas % 24;

            resposta = "Serão usados " + engradados + " engradados";
            resposta += "\nSobrarão " + sobra + " cervejas soltas";

            lbResp.Text = resposta;

        }
    }
}