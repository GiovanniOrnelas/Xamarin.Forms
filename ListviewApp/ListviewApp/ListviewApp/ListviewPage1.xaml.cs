using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListviewApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListviewPage1 : ContentPage
    {
        public ListviewPage1()
        {
            InitializeComponent();

            List<String> itens = new List<string>()
            {
                "Palmeiras","Flamengo","Santos","Atletico","Botafogo"
            };
            ListView.ItemsSource = itens;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Item selecionado: ", e.SelectedItem.ToString(), "OK");
        }
    }
}