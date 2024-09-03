namespace CursoMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Views.Box_View();
    }
}
