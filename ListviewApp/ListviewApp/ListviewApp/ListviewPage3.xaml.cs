using ListviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListviewApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListviewPage3 : ContentPage
    {
        public ListviewPage3()
        {
            InitializeComponent();
            listview.ItemsSource = new List<Time>
            {
                new Time { Nome="Palmeiras", Pontos=69,
                Imagem ="http://macoratti.net/Imagens/times/palmeiras64.png" },

                new Time { Nome="Flamengo", Pontos=67,
                Imagem ="http://macoratti.net/Imagens/times/flamengo64.jpg" },

                new Time { Nome="Santos", Pontos=64,
                Imagem ="http://macoratti.net/Imagens/times/santos64.jpg" },

                new Time { Nome="Atletico", Pontos=62,
                Imagem ="http://macoratti.net/Imagens/times/atletico64.jpg" },

                new Time { Nome="Botafogo", Pontos=59,
                Imagem ="http://macoratti.net/Imagens/times/botafogo64.jpg" }
            };
        }
    }
}