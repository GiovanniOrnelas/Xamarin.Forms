using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RelativeLayoutApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RelativePage();
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
