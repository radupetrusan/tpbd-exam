using System.Drawing;
using System.IO;

namespace Calculator_Salariu.Utils
{
    class ImageUtils
    {
        public static byte[] ConvertFileToByte(string path)
        {
            try
            {
                var info = new FileInfo(path);

                var bytes = info.Length;

                var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                var reader = new BinaryReader(stream);

                var data = reader.ReadBytes((int)bytes);

                return data;
            }
            catch
            {
                return null;
            }
            
        }

        public static Image ConvertByteToImage(byte[] photo)
        {
            using (var memoryStream = new MemoryStream(photo, 0, photo.Length))
            {
                try
                {
                    memoryStream.Write(photo, 0, photo.Length);
                    var image = Image.FromStream(memoryStream, true);

                    return image;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
