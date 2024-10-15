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
        App.FlyoutPage.IsPresented = true;  // Cierra el men� Flyout despu�s de la navegaci�n
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

    private void OnNavigateToCommitPage(object sender, EventArgs e)
    {
        goToPage(new Pages.CommitPage());

    }
}