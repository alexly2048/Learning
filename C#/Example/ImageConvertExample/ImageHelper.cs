using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageConvertExample
{
   public class ImageHelper
    {
        public string FromImageToBase64(string filePath)
        {
            try
            {
                string result = string.Empty;

                if (string.IsNullOrEmpty(filePath))
                    throw new Exception("请输入文件路径");
                if (!File.Exists(filePath))
                    throw new Exception("文件不存在");
                using (FileStream fs = File.OpenRead(filePath))
                {
                    byte[] tmp = new byte[fs.Length];
                    fs.Read(tmp, 0,(int)fs.Length);
                    result = Convert.ToBase64String(tmp);
                }
                return result;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void SaveImageFromBase64(string image,string destination,ImageFormat imageFormat)
        {
            try
            {
                if (string.IsNullOrEmpty(image) || string.IsNullOrEmpty(destination))
                {
                    throw new Exception("请输入图片信息和保存地址");
                }
                byte[] imageByte = Convert.FromBase64String(image);
                using(MemoryStream ms = new MemoryStream())
                {
                    ms.Write(imageByte, 0, imageByte.Length);
                    Bitmap imageFile = new Bitmap(ms);
                    imageFile.Save(destination,imageFormat);
                }
                
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
