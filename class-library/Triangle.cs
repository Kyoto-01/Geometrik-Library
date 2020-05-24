using System.Drawing;

namespace Geometrik
{
    public class Triangle : Polygon
    {
        public Triangle(int height, int width, int posX, int posY, bool fill)
            : base(height, width, posX, posY, fill) { }

        protected override Point[] SetFormat()
        {
            Point[] PolygonFormat = new Point[4];
            PolygonFormat[0] = new Point(PositionX + Width, PositionY);
            PolygonFormat[1] = new Point(PositionX, PositionY + Height);
            PolygonFormat[2] = new Point(Width * 2, PositionY + Height);
            PolygonFormat[3] = new Point(PositionX + Width, PositionY);

            return PolygonFormat;
        }
    }
}
