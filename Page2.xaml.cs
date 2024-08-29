namespace CursoMAUI;

public partial class Page2 : ContentPage
{
    public Page2()
    {
        InitializeComponent();
        LoadImages();
    }

    private void LoadImages()
    {
        List<string> images =
        [
            "iconouno.png",
            "iconodos.png",
            "iconotres.png",
            "iconocuatro.png",
            "iconocinco.png",
            "iconoseis.png",
            "iconosiete.png",
            "iconoocho.png",
            "icononueve.png",
            "iconodiez.png",
            "iconoonce.png",
            "iconodoce.png",
            "iconotrece.png",
            "iconocatorce.png",
            "iconoquince.png",
            "iconouno.png",
            "iconodos.png",
            "iconotres.png",
            "iconocuatro.png",
            "iconocinco.png",
            "iconoseis.png",
            "iconosiete.png",
            "iconoocho.png",
            "icononueve.png",
            "iconodiez.png",
            "iconoonce.png",
            "iconodoce.png",
            "iconotrece.png",
            "iconocatorce.png",
            "iconoquince.png",
        ];

        foreach (string item in images)
        {
            Image image = new()
            {
                Source = ImageSource.FromFile(item),
            };

            flexLayout.Children.Add(image);
        }
    }
}