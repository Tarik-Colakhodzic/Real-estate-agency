using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RealEstateAgency.WinUI
{
    public class ImageHelper
    {
        public static byte[] FromImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image FromByteToImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }
    }
}