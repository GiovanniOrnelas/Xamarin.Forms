using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExercicioAbsolutPage
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
    }
}
