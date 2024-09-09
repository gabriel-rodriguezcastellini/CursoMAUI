using CursoMAUI.Data;

namespace CursoMAUI.Views;

public partial class Graphics_View : ContentPage
{
    public Graphics_View()
    {
        InitializeComponent();
    }

    private void GraphicsView_StartHoverInteraction(object sender, TouchEventArgs e)
    {
        if (sender is GraphicsView graphicsView && graphicsView.Drawable is GraphicsDrawable drawable)
        {
            drawable.LineColor = Colors.Blue;
            graphicsView.Invalidate();
        }
    }
}