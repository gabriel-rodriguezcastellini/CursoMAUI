namespace CursoMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Views.Graphics_View();
    }
}
