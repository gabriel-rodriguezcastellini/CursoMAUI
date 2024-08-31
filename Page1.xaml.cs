using CursoMAUI.ViewModels;

namespace CursoMAUI;

public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();
        BindingContext = new PrincipalViewModel();
    }
}