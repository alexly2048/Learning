using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace ImageConvertExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageHelper helper = new ImageHelper();
            // 将图片转换为Base64
            string filePath = @"E:\Document\0_PersonalDocument\996_PrivatePictures\Girl1.jpg";
            string result = helper.FromImageToBase64(filePath);
            Console.WriteLine("Convert from Image to Base64 string:\t{0}", result);
            // 将Base64转换为Image并保存
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "base.bmp";
            helper.SaveImageFromBase64(result, fileName, ImageFormat.Bmp);
            Console.ReadKey();
        }
    }
}
