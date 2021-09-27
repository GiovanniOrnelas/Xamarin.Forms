using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ActivityIndicatorApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage2 : ContentPage
    {
        public ImagePage2()
        {
            InitializeComponent();

            image.Source = new UriImageSource
            {
                Uri = new Uri("https://images8.alphacoders.com/468/thumb-1920-468739.jpg"),
                CachingEnabled = false
            };

        }
    }
}