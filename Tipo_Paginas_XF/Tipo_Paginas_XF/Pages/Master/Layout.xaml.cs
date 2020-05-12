using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tipo_Paginas_XF.Pages.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Layout : MasterDetailPage
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs args)
        {

            string page = ((Button)sender).BindingContext as string;

            switch (page)
            {
                case "Pagina1":
                    Detail = new Navigation.Page1();
                    IsPresented = false;
                    break;
                case "Pagina2":
                    Detail = new Navigation.Page2();
                    IsPresented = false;
                    break;
                case "Conteudo":
                    Detail = new Pages.Master.Content();
                    IsPresented = false;
                    break;
                default:
                    break;
            }

            
        }
    }
}