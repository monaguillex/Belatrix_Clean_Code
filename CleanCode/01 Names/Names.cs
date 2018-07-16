using System.Drawing;

namespace CleanCode.Names
{
    public class Names
    {
        public Bitmap CreateGraphicFromBitmap(string fileName)
        {
            var bitmap = new Bitmap(fileName);
            var canvas = Graphics.FromImage(bitmap);
            canvas.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            canvas.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            canvas.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return bitmap;
        }
    }
}
