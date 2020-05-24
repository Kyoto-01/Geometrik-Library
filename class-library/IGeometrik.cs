using System.Drawing;

namespace Geometrik
{
    interface IGeometrik
    {
        int Height { get; set; }
        int Width { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
        bool Fill { get; set; }
        Color ColorObject { get; set; }
        int LineThickness { get; set; }

        void DrawFormat(System.Windows.Forms.PaintEventArgs e);
    }
}
