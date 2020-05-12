using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tipo_Paginas_XF.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnMudarPagina_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Navigation.Page2());
        }

        private void btnModal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.Navigation.Modal());
        }

        private void btnLayout_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Master.Layout();
        }
    }
}