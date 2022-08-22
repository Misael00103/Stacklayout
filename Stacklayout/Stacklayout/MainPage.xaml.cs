using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace Stacklayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLeerMas_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/Guido_van_Rossum", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLeerMas1_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/Brendan_Eich", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLeerMas2_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/Rasmus_Lerdorf", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLeerMas3_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/Matt_Mullenweg", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLeerMas4_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/Tim_Berners-Lee", BrowserLaunchMode.SystemPreferred);
        }
    }
}




