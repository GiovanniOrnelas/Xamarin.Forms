using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackLayoutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();

            /* var layout = new StackLayout { 
                BackgroundColor = Color.Black,
                Spacing = 20,
                Padding = new Thickness (0,20,0,0),
                Orientation = StackOrientation.Vertical,           
            };

            layout.Children.Add(new Label { Text = "Opção1", TextColor = Color.White});
            layout.Children.Add(new Button { Text = "Enviar", TextColor = Color.White });

            Content = layout;*/

            StackLayout stacklayout = new StackLayout {
                BackgroundColor = Color.Black,
                Spacing = 20,
                Padding = new Thickness(0, 20, 0, 0),
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label
                    {
                        Text = "Opção 1", TextColor = Color.White, HorizontalOptions = LayoutOptions.Start
                    },

                    new Label
                    {
                        Text = "Opção 2", TextColor = Color.White, HorizontalOptions = LayoutOptions.Center
                    },

                    new StackLayout
                    {
                         BackgroundColor = Color.Black,
                         Spacing = 10,
                         Padding = new Thickness(30),
                         Orientation = StackOrientation.Horizontal,
                         HorizontalOptions = LayoutOptions.Center,

                        Children = 
                        {
                            new Label
                            {
                                Text = "Opção 3", TextColor = Color.White,
                            },

                             new Label
                             {
                                Text = "Opção 4", TextColor = Color.White, 
                             },
                        }
                    },
                }
            };

            Content = stacklayout;
        }
    }
}