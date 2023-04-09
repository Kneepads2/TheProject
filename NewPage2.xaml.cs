using TheProject.Repository;
using TheProject.model;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;
using Newtonsoft.Json.Linq;
using System.Reflection;


namespace TheProject;

public partial class NewPage2 : ContentPage
{
    public NewPage2()
    {
        InitializeComponent();
    }
    private async void accountCreated(object sender, EventArgs e)
    {
        if (createUsername.Text.Length < 1 || createPassword.Text.Length < 1)
        {
            try
            {
                await DisplayAlert("Account Format", "Please fill in both textboxes", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }

        }
        else if (createUsername.Text.Length <= 6 || createPassword.Text.Length <= 6)
        {
            await DisplayAlert("Account Format", "Your password and account must be longer than 6 characters", "OK");

        }
        else
        {
            try {
                string username = createUsername.Text;
                string password = createPassword.Text;
                double savingsBalance = 0;
                double chequeBalance = 0;

                BankAccount newAccount = new BankAccount(
                    username,
                    password,
                    savingsBalance,
                    chequeBalance
                );


                // Add the new account to the list and write to the JSON file
                BankAccountRepository.AddAccountToList(newAccount);
                BankAccountRepository.WriteToJsonFile(BankAccountRepository.GetList(), "BankAccounts.json");


                // Display a message box to confirm creation of account
                await DisplayAlert("Account Creation Success", "Account has been created.\nPlease head back to the main menu and login using your new account!", "OK");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }

        }
    } 
}
