using CursoMAUI.Views;

namespace CursoMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Image_View();
    }
}
