namespace MauiHamburgerTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MenuPage mp = new MenuPage();
        Application.Current.MainPage = mp;
    }
}
