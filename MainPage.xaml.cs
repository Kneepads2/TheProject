using TheProject.model;
using TheProject.Repository;
using System.Text.Json;

namespace TheProject;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
       /* Device.BeginInvokeOnMainThread(async () =>
        {
            await LoadMauiAssetAsync();
        }); */

    }

    private async void loginClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new NewPage3());
    }
    private async void createClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage2());
    }

    /*async Task LoadMauiAssetAsync()
    {
        var stream = await FileSystem.OpenAppPackageFileAsync("account.json");
        if (stream != null)
        {
            List<BankAccount> account = JsonSerializer.Deserialize<List<BankAccount>>(stream);
            //this.listviewlv.ItemsSource = drugs;
        }

    }*/


}