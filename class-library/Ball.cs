using System.Drawing;

namespace Geometrik
{
    public class Ball: FormatGeometric
    {
        public Ball(int height, int width, int posX, int posY, bool fill)
            : base(height, width, posX, posY, fill){}

        protected override void DrawFill(Graphics graphic, Brush fillBrush, Rectangle rect)
        {
            graphic.FillEllipse(fillBrush, rect);
        }

        protected override void  DrawOutline(Graphics graphic, Pen outlinePen, Rectangle rect)
        {
            graphic.DrawEllipse(outlinePen, rect);
        }
    }
}
