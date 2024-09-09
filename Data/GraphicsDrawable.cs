namespace CursoMAUI.Data;

public class GraphicsDrawable : IDrawable
{
    public Color LineColor { get; set; } = Colors.Red;
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        //Configuramos y dibujamos la linea
        canvas.StrokeColor = LineColor;
        canvas.StrokeSize = 4;
        canvas.StrokeDashPattern = [2, 2];
        canvas.DrawLine(0, 0, 100, 100);

        // calcular el centro del lienzo
        float centerX = dirtyRect.Center.X;
        float centerY = dirtyRect.Center.Y;

        // ajustar los puntos finales de la línea para que estén en el centro del lienzo
        float startX = centerX - 100; // 100 es la mitad del ancho de la línea
        float startY = centerY - 100; // 100 es la mitad de la altura de la línea
        float endX = centerX + 100;
        float endY = centerY + 100;

        // dibujar la línea
        canvas.DrawLine(startX, startY, endX, endY);
    }



}
