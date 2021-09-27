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
    public partial class Exercicio1 : ContentPage
    {
        public Exercicio1()
        {
            InitializeComponent();

            int contador = 1;

            StackLayout stack = new StackLayout();
            stack.Spacing = 20;
            while (contador <= 25)
            {
                stack.Children.Add(new Button { Text = "Button " + contador, BackgroundColor = Color.Yellow });
                contador++;
            }

            ScrollView scroll = new ScrollView
            {
                Content = stack
            };

            Content = scroll;
        }
    }
}