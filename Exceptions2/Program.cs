using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Directory.GetFiles(Directory.GetCurrentDirectory());
            Regex regexExtForImage = new Regex("^((bmp)|(gif)|(tiff?)|(jpe?g)|(png))$", RegexOptions.IgnoreCase);
            foreach (string file in data)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(file);
                    Bitmap mirrored = (Bitmap)bitmap.Clone();
                    mirrored.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    string newfile = new Regex(".[a-b]").Replace(file, string.Empty) + "-mirrored.gif";
                    mirrored.Save(newfile);
                }
                catch
                {
                    if (regexExtForImage.IsMatch(Path.GetExtension(file))) Console.WriteLine("Файл не був прочитаний, хоча мав би бути");
                }
            }
        }
    }
}