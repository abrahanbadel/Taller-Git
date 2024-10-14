namespace Taller_Git
{
    public partial class MainPage : FlyoutPage
    {

        public MainPage()
        {
            InitializeComponent();

            Flyout = new Maestro();
            Detail = new NavigationPage(new Detalle());

            App.FlyoutPage = this;
        }

        
    }

}
