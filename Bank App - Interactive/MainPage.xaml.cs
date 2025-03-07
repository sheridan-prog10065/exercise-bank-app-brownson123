namespace BankApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		
	}

	private void OnNewUser(object? sender, EventArgs e)
	{
		_menuLayout.IsVisible = false;
		_accountScrollView.IsVisible = true;
	}

	private void OnExistingUser(object? sender, EventArgs e)
	{
		_menuLayout.IsVisible = false;
	}

	private void OnAddAccount(object? sender, EventArgs e)
	{
		throw new NotImplementedException();
	}
}
