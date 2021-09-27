using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StepperApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepperPage1 : ContentPage
    {
        public StepperPage1()
        {
            InitializeComponent();
        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}