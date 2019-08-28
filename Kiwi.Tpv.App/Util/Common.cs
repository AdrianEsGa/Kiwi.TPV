using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Kiwi.Tpv.App.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Util
{
    public static class Common
    {

        public static byte[] ImageToBytes(Image image)
        {
            try
            {
                var ms = new MemoryStream();
                image.Save(ms, ImageFormat.Gif);
                return ms.ToArray();
            }

            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static Image BytesToImage(byte[] bytes)
        {
            try
            {
                var ms = new MemoryStream(bytes, 0, bytes.Length);
                ms.Write(bytes, 0, bytes.Length);
                var returnImage = Image.FromStream(ms, true);
                return returnImage;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}