using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListviewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListviewPage4();
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
