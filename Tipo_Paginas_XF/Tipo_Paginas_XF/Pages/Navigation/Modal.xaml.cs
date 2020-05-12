
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tipo_Paginas_XF.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal : ContentPage
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void btnFecharModal_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}