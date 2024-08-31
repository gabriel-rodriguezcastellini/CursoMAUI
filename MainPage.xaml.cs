using CursoMAUI.Pages;

namespace CursoMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        FlyoutPageItem flyoutPageItem = new()
        {
            Title = "Navigation Pages Example",
            IconSource = "contact.png"
        };

        await Navigation.PushAsync(new Page2()
        {
            BindingContext = flyoutPageItem
        });
    }
}
