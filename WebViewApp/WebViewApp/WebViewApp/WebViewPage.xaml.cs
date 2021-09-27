using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        private void btnExibir_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryUrl.Text))
            {
                DisplayAlert("WEBSITE", "URL INVÁLIDA", "CONFIRMAR");
            }
            else
            {
                webview.Source = entryUrl.Text;
            }
        }

        private void exibirHTML_Clicked(object sender, EventArgs e)
        {
            var html = new HtmlWebViewSource();

            html.Html = @"<html><body> 
                        <p><font color = '#800080'><b>SENAC - TI20 - UC11</b></font></p>
                        <p> UC de Xamarin Forms - Mobile</p>
                        </body></html>";

            webview.Source = html;
        }

        private void exibirHTMLLocal_Clicked(object sender, EventArgs e)
        {
            var html = new HtmlWebViewSource();
            html.BaseUrl = DependencyService.Get<IBaseUrl>().Get();

            webview.Source = html.BaseUrl;
        }
    }
}