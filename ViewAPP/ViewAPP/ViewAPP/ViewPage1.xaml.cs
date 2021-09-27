using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPage1 : ContentPage
    {
        public ViewPage1()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbl.Text = e.NewTextValue;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            lbl.Text = "Evento Completet Disparado";
        }
    }
}