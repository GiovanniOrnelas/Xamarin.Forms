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
    public partial class Prefeitura : ContentPage
    {
        public Prefeitura()
        {
            InitializeComponent();
        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
            double salario, prestacao, prestacaoValida;
            string resposta = "";

            salario = Convert.ToDouble(etSalario.Text);

            prestacao = Convert.ToDouble(etprestacao.Text);

            prestacaoValida = salario * 0.30;

            if (prestacao > prestacaoValida)
            {
                resposta = "\nPrestação mal sucedida, valor máximo é de: R$" + prestacaoValida;
            }

            else
            {
                resposta += "\nPrestação bem sucedida, você resgatou R$" + prestacaoValida; 
            }

            lbResp.Text = resposta;
        }
    }
}