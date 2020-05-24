using System.Drawing;

namespace Geometrik
{
    public abstract class Polygon : FormatGeometric
    {
        public Polygon(int height, int width, int posX, int posY, bool fill)
            : base(height, width, posX, posY, fill) { }

        protected abstract Point[] SetFormat();

        protected override void DrawFill(Graphics graphic, Brush fillBrush, Rectangle rect)
        {
            graphic.FillPolygon(fillBrush, SetFormat());
        }

        protected override void DrawOutline(Graphics graphic, Pen outlinePen, Rectangle rect)
        {
            graphic.DrawPolygon(outlinePen, SetFormat());
        }
    }
}
