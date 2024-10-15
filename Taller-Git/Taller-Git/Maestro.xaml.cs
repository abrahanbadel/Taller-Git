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


}