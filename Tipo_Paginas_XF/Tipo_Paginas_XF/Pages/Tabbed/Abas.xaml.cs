
using Tipo_Paginas_XF.Pages.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tipo_Paginas_XF.Pages.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new Page1()) { Title = "Item 3" });
        }
    }
}