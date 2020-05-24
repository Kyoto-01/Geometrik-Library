using System.Drawing;

namespace Geometrik
{
    public abstract class FormatGeometric : IGeometrik
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool Fill { get; set; }
        public Color ColorObject { get; set; }
        public int LineThickness { get; set; }

        public FormatGeometric(int height, int width, int posX, int posY, bool fill)
        {
            this.Height = height;
            this.Width = width;
            this.PositionX = posX;
            this.PositionY = posY;
            this.Fill = fill;
            this.ColorObject = Color.Red;
        }

        public void DrawFormat(System.Windows.Forms.PaintEventArgs e)
        {
            Rectangle proportions = new Rectangle(PositionX, PositionY, Width, Height);
            using (Graphics graphic = e.Graphics)
            {
                if (Fill)
                {
                    Brush fillBrush = new SolidBrush(ColorObject);
                    DrawFill(graphic, fillBrush, proportions);
                    fillBrush.Dispose();
                    return;
                }
                Pen outlinePen = new Pen(ColorObject, LineThickness);
                DrawOutline(graphic, outlinePen, proportions);
                outlinePen.Dispose();
            }
        }

        protected abstract void DrawFill(Graphics graphic, Brush fillBrush, Rectangle rect);
        protected abstract void DrawOutline(Graphics graphic, Pen outlinePen, Rectangle rect);
    }
}
