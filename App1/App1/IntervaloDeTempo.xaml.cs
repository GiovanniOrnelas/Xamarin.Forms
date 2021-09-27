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
    public partial class IntervaloDeTempo : ContentPage
    {
        public IntervaloDeTempo()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            int tempo, semanas, anos, meses, dias;
            string resposta = "";

            tempo = Convert.ToInt32(etDias.Text);

            resposta = tempo + " dias tem";

            anos = tempo / 365;
            tempo = tempo % 365;
            meses = tempo / 30;
            tempo = tempo % 30;
            semanas = tempo / 7;
            tempo = tempo % 7;
            dias = tempo;

            resposta += "\n";
            resposta += "\n" + anos + " anos";
            resposta += "\n" + meses + " meses";
            resposta += "\n" + semanas + " semanas";
            resposta += "\n" + dias + " dias";

            lbResp.Text = resposta;



        }
    }
}