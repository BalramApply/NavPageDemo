namespace NavPageDemo;

public partial class GreenPage : ContentPage
{
	public GreenPage()
	{
		InitializeComponent();
	}

    // main_page
    public async void GoMain(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    // red_page
    private async void GoRed(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RedPage());
    }

    // blue_page
    private async void GoBlue(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BluePage());
    }
}