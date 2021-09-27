using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Exercicio1();          

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        Image img = new Image { Source = "https://www.tvgazeta.com.br/wp-content/uploads/2016/01/revista-cidade-receitas-torta-maca-enfeiticada.jpg" };

    }
}
