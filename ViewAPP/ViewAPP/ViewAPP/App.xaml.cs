using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MaskViewApp1();
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
