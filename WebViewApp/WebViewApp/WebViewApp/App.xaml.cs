﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WebViewPage();
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
