namespace Taller_Git;

public partial class Maestro : ContentPage
{
	public Maestro()
	{
		InitializeComponent();
	}

    private void goToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented = false;  // Cierra el menú Flyout después de la navegación
    }

    private void OnNavigateToFetchPage(object sender, EventArgs e)
    {
        goToPage(new Pages.FetchPage());
    }

    private void OnNavigateToPushPage(object sender, EventArgs e)
    {
        goToPage(new Pages.PushPage());
    }

    private void OnNavigateToPullPage(object sender, EventArgs e)
    {
        goToPage(new Pages.PullPage());
    }
}