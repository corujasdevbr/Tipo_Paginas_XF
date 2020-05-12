using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tipo_Paginas_XF.Pages.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void btnPlay_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new Pages.Navigation.Page1());
            App.Current.MainPage = new NavigationPage(new Pages.Tabbed.Abas());
        }
    }
}