using System.Drawing;

namespace NeuralNetworkMaker.Preferences.Extensions
{
    internal static class GraphicsExtensions
    {
        public static void DrawTransparentRectangle(this Graphics graph, Size size)
        {
            int smallRect = 5;

            for (int y = 0; y <= size.Height; y += smallRect)
            {
                var isWhite = y % 2 == 0;
                for (int x = 0; x <= size.Width; x += smallRect)
                {
                    graph.FillRectangle(isWhite ? Brushes.White : Brushes.LightGray, new Rectangle(x, y, smallRect, smallRect));
                    isWhite = !isWhite;
                }
            }
        }
    }
}
