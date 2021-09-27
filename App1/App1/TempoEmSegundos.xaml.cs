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
    public partial class TempoEmSegundos : ContentPage
    {
        public TempoEmSegundos()
        {
            InitializeComponent();
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            int horas, minutos, tempoTotal, minutosResto, segundos;
            string resposta = "";

            tempoTotal = Convert.ToInt32(etSegundos.Text);


            horas = tempoTotal / 3600; 
            minutosResto = tempoTotal % 3600;
            minutos = minutosResto / 60;
            segundos = minutosResto % 60;

            resposta = "O horário digitado tem " + horas + " horas";
            resposta += "\n" + minutos + "minutos";
            resposta += "\n" + segundos + "segundos";

            lbResp.Text = resposta;
        }
    }
}