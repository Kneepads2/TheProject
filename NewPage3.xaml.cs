namespace TheProject;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
    private async void savingClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new NewPage1());
    }
    private async void chequingClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage4());
    }
    private void chequeHelpClicked(object sender, EventArgs e)
    {
        chequeInfo.Text = "This is your chequing account.\nThis account is used to make transacations and for business purposes.";

    }
    private void savingsHelpClicked(object sender, EventArgs e)
    {
        savingsInfo.Text = "This is your savings account.\nThis account should be used to save money for the future.";
    }
}