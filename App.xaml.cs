using CursoMAUI.Pages;

namespace CursoMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPageT();
        }
    }
}
