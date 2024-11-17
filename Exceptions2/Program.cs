using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Directory.GetFiles(Directory.GetCurrentDirectory());
            Regex regexExtForImage = new Regex("^((bmp)|(gif)|(tiff?)|(jpe?g)|(png))$", RegexOptions.IgnoreCase);,
            foreach (string file in data)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(file);
                }
                catch
                {

                }
            }
        }
    }
}