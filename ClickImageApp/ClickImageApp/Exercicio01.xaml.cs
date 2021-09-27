using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClickImageApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercicio01 : ContentPage
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("Exercício07" , "Apenas um teste" , "OK");
        }
    }
}