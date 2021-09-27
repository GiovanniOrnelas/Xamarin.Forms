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
    public partial class MaskViewApp1 : ContentPage
    {
        public MaskViewApp1()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (dtp1 != null)
            {
                lbl.Text = String.Format("{0:MM/dd/yyyy}", dtp1.Date);
            }          
        }
    }
}