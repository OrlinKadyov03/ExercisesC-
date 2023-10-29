using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDownscaler
{
    public class ImageDownscaler
    {
        public static Bitmap DownscaleImageSequential(Bitmap originalImage, int newWidth, int newHeight)
        {
            Bitmap downscaledImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(downscaledImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }
            return downscaledImage;
        }

        public static Bitmap DownscaleImageParallel(Bitmap originalImage, int newWidth, int newHeight)
        {
            Bitmap downscaledImage = new Bitmap(newWidth, newHeight);
            Parallel.For(0, newHeight, y =>
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int sourceX = (int)(x * (originalImage.Width / (float)newWidth));
                    int sourceY = (int)(y * (originalImage.Height / (float)newHeight));
                    Color pixelColor = originalImage.GetPixel(sourceX, sourceY);
                    downscaledImage.SetPixel(x, y, pixelColor);
                }
            });
            return downscaledImage;
        }
    }
}
