namespace CursoMAUI.Views;

public partial class Image_View : ContentPage
{
    public Image_View()
    {
        InitializeComponent();
        Designer.Add(new Image { Source = ImageSource.FromResource("CursoMAUI.GifImages.formatgif.gif"), WidthRequest = 100, HeightRequest = 100 });
    }
}