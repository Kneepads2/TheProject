namespace TheProject;

public partial class NewPage2 : ContentPage
{
    public NewPage2()
    {
        InitializeComponent();
    }
    public void accountCreated(object sender, EventArgs e)
    {
        if (username.Text == "" || createPassword.Text == "")
        {
            DisplayAlert("Empty Box", "Please fill in all textboxes", "OK");

        }
    }
}