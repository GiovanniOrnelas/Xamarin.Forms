using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AbsolutePage10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutePage1 : ContentPage
    {
        public AbsolutePage1()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();

            var box1 = new BoxView 
            { 
                Color = Color.Blue               
            };

            var box2 = new BoxView
            {
                Color = Color.Red
            };

            layout.Children.Add(box1, new Rectangle(0,0,1,1), AbsoluteLayoutFlags.All);
            layout.Children.Add(box2, new Rectangle(0.5, 0.1, 100, 100), AbsoluteLayoutFlags.PositionProportional);

            var button1 = new Button 
            {
                Text = "SENAC TI-20",
                BackgroundColor = Color.Black,
                TextColor = Color.White
            };

            layout.Children.Add(button1, new Rectangle(0, 0.95, 1, 40), AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);


            Content = layout;
        }
    }
}