using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace sales_management_software
{
    public class SpecFunctions
    {
        // resize ảnh
        public static Image resizeImage(Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        // Xén ảnh tròn
        public static Image RoundCorners(Image StartImage /*, int CornerRadius*/, Color BackgroundColor)
        {
            // Để tròn thì CornerRadius = Width / 2
            int CornerRadius = StartImage.Width / 2;

            CornerRadius++;
            CornerRadius *= 2;

            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);

            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Brush brush = new TextureBrush(StartImage);

                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);

                return RoundedImage;
            }
        }

        // Mã hóa chuỗi cho Mật khẩu
        //Use: textBox1.Text = (GetHash(textBox1.Text));
        public static string GetHash(string plainText)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = Encoding.ASCII.GetBytes(plainText);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                strBuilder.Append(hash[i].ToString("X2"));
            }

            return strBuilder.ToString();
        }

        // xử lý ảnh
        public static string ImageToBase64 (Image img)
        {
            var ms = new MemoryStream();
            img = resizeImage(img, new Size(128, 128));
            img.Save(ms, ImageFormat.Png);

            byte[] a = ms.GetBuffer();
            string output = Convert.ToBase64String(a);
            
            return output;

        }

        // xử lý ảnh
        public static Image Base64toImage(string str)
        {
            byte[] b = Convert.FromBase64String(str);
            var ms = new MemoryStream(b);
            ms.Write(b, 0, b.Length);

            Bitmap output = new Bitmap(ms);
            Image img = output;

            return img;

        }

    }
}
