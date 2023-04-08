namespace TheProject;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
	private async void accountCreated(object sender, EventArgs e)
	{
		if (username.Text.Length < 1 || createPassword.Text.Length < 1)
        {
            DisplayAlert("Account Format", "Please fill in both textboxes", "OK"); 

        }
        else if (username.Text.Length <= 6 || createPassword.Text.Length <= 6)
		{
			DisplayAlert("Account Format", "Your password and account must be longer than 6 characters", "OK");

		}
        else
		{
			DisplayAlert("Success!", "Account has been successfully created!\nPlease return to the main menu and login with your newly created account!", "OK");
            
        }
	}
}