namespace NavPageDemo;

public partial class RedPage : ContentPage
{
	public RedPage()
	{
		InitializeComponent();
	}

    // main_page
    public async void GoMain(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    // green_page
    private async void GoGreen(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GreenPage());
    }

    // blue_page
    private async void GoBlue(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BluePage());
    }
}