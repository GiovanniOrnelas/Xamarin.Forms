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
    public partial class ClickImage : ContentPage
    {
        public ClickImage()
        {
            InitializeComponent();

            /*var image = new Image() 
            {
                Source= "https://images2.alphacoders.com/838/thumb-1920-838311.jpg",
                Aspect=Aspect.AspectFit
            };

            var tapGestureRecognizer = new TapGestureRecognizer();           

            image.GestureRecognizers.Add(tapGestureRecognizer);

            tapGestureRecognizer.Tapped += async (sender, e) =>
            {
                image.Opacity = 0.5;
                await Task.Delay(1000);
                image.Opacity = 1;
            };

            Content = image;*/
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            image.Opacity = 0.5;
            await Task.Delay(1000);
            image.Opacity = 1;
        }
    }
}