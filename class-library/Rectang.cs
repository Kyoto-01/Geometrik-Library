using System.Drawing;

namespace Geometrik
{
    public class Rectang : FormatGeometric
    {
        public Rectang(int height, int width, int posX, int posY, bool fill)
            : base(height, width, posX, posY, fill){}

        protected override void  DrawFill(Graphics graphic, Brush fillBrush, Rectangle rect)
        {
            graphic.FillRectangle(fillBrush, rect);
        }

        protected override void DrawOutline(Graphics graphic, Pen outlinePen, Rectangle rect)
        {
            graphic.DrawRectangle(outlinePen, rect);
        }
    }
}
