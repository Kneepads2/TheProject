namespace TheProject;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    private async void loginClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new NewPage1());
    }
    private async void createClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage2());
    }

}