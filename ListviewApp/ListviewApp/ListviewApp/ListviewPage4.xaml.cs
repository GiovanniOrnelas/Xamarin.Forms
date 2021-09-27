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
    public partial class ListviewPage4 : ContentPage
    {
        public ListviewPage4()
        {
            InitializeComponent();
            listview.ItemsSource = new List<Timegrupo>

            {
                new Timegrupo ("A", "A")
                {
                     new Time { Nome="Atletico Paranaense", Pontos=52,
                Imagem ="https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/CA_Paranaense.svg/1200px-CA_Paranaense.svg.png" },
                    
                    new Time { Nome = "América  - MG", Pontos = 62,
                Imagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/Escudo_do_America_Futebol_Clube.svg/1200px-Escudo_do_America_Futebol_Clube.svg.png" }
                },

                new Timegrupo ("B", "B")
                {
                    new Time { Nome = "Botafogo", Pontos = 59,
                Imagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Botafogo_de_Futebol_e_Regatas_logo.svg/1200px-Botafogo_de_Futebol_e_Regatas_logo.svg.png" }
                },

                new Timegrupo ("F", "F")
                {
                    new Time { Nome = "Flamengo", Pontos = 67,
                Imagem = "https://i.pinimg.com/originals/0e/16/4f/0e164f187b05c40f2985de02b5307c78.png" }
                },

                new Timegrupo ("P", "P")
                {
                    new Time { Nome = "Palmeiras", Pontos = 69,
                Imagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Palmeiras_logo.svg/1200px-Palmeiras_logo.svg.png" }
                },

                new Timegrupo ("S", "S")
                {
                    new Time { Nome = "Santos", Pontos = 64,
                Imagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/Santos_logo.svg/1200px-Santos_logo.svg.png" }
                },

            };
        }
    }
}