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
    public partial class ListviewPage2 : ContentPage
    {
        public ListviewPage2()
        {
            InitializeComponent();

            listview.ItemsSource = new List<Time>
            {
                new Time{Nome="Palmeiras", Pontos = 69, Imagem = "http://pm1.narvii.com/6993/661bbf29a4ac7ec6eb8d904ffb7fa434857ead58r1-720-703v2_uhq.jpg"},

                new Time{Nome="Flamengo", Pontos = 67, Imagem = "https://a.espncdn.com/i/teamlogos/soccer/500/819.png"},

                new Time{Nome="Santos", Pontos = 45, Imagem = "https://s2.glbimg.com/stq3QDQSaE0wM9JdA02hlIuIepg=/1200x/smart/filters:cover():strip_icc()/i.s3.glbimg.com/v1/AUTH_08fbf48bc0524877943fe86e43087e7a/internal_photos/bs/2021/B/t/CTmRsxTTOZFTo96PhcFw/santos.png"},

                new Time{Nome="Atletico", Pontos = 75, Imagem = "https://static-wp-tor15-prd.torcedores.com/wp-content/uploads/2021/09/atletico-mg-610x338.jpg"},

                new Time{Nome="Botafogo", Pontos = 66, Imagem = "https://s2.glbimg.com/j5StYFUwpsjWzvADx-eJUoNYGyk=/0x0:984x554/984x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_bc8228b6673f488aa253bbcb03c80ec5/internal_photos/bs/2021/B/0/NImJl6Thu7yj3dBASS3g/carrossel-botafogo-financas.jpg"}

            };
        }
    }
}