namespace TheProject;

public partial class NewPage2 : ContentPage
{
    public NewPage2()
    {
        InitializeComponent();
    }
    private async void accountCreated(object sender, EventArgs e)
    {
        if (username.Text == "" || createPassword.Text == "")
        {
            DisplayAlert("Empty Box", "Please fill in all textboxes", "OK");

        }
        else
        {
            DisplayAlert("Success!", "Account has been successfully created!\nPlease return to the main menu and login with your newly created account!", "OK");
            //await Navigation.PushAsync(new MainPage());
        }
    }
}