﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClickImageApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Exercicio02();
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