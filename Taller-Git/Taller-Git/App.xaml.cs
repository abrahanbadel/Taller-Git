namespace Taller_Git
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pages.CommitPage();
        }
    }
}
