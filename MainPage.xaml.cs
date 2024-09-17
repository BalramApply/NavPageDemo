namespace NavPageDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
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

}
