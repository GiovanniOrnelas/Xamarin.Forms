using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollViewApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercicio2 : ContentPage
    {
        public Exercicio2()
        {
            InitializeComponent();

            List<string> lista = GetImagens();
            StackLayout stack = new StackLayout();
            stack.Spacing = 10;
            for (var i = 0; i < lista.Count; i++)
            {
                stack.Children.Add(new Image
                {
                    Source = lista[i],
                    HeightRequest = 300,
                    WidthRequest = 300,
                    Aspect = Aspect.AspectFill
                });
            }
            var scroll = new ScrollView() { Content = stack };
            Content = scroll;
        }

        public List<string> GetImagens()
        {
            List<string> Lista = new List<string>();
            Lista.Add("https://st2.depositphotos.com/6544740/9337/i/600/depositphotos_93376372-stock-photo-sunset-over-sea-pier.jpg");
            Lista.Add("https://ciclovivo.com.br/wp-content/uploads/2018/10/iStock-536613027.jpg");
            Lista.Add("https://marketingcomcafe.com.br/wp-content/uploads/2017/12/banco-imagens-gratis.png");
            Lista.Add("https://i0.wp.com/gamelogia.com.br/wp-content/uploads/2019/01/assassins-creed-odyssey-7.jpg?fit=1068%2C601&ssl=1");
            Lista.Add("https://gizmodo.uol.com.br/wp-content/blogs.dir/8/files/2021/06/b2080d073a54c371ff49f4277b74bf93-800x450.jpg");
            Lista.Add("https://s2.glbimg.com/OcK_esbrmlsULSGxLV7JnkROJQo=/512x320/smart/e.glbimg.com/og/ed/f/original/2020/08/11/31669212-8603391-a_king_eidar_duck_bathing_in_some_shallow_water-a-28_1596787696775.jpg");
            Lista.Add("https://cdn.pixabay.com/index/2021/08/24/12-15-37-929_1440x550.jpg");

            return Lista;       
        }
    }
}