using System;
using System.IO;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        string path = @"H:\SteamLibrary\steamapps\common\Suzerain\Mods\GreatZilleAssets\ZilleTile_1.png";
        if (!File.Exists(path))
        {
            Console.WriteLine("File not found: " + path);
            return;
        }

        using (var bmp = new Bitmap(path))
        {
            Console.WriteLine($"Image size: {bmp.Width}x{bmp.Height}, PixelFormat: {bmp.PixelFormat}");
            var center = bmp.GetPixel(bmp.Width / 2, bmp.Height / 2);
            Console.WriteLine($"Center pixel: R={center.R}, G={center.G}, B={center.B}, A={center.A}");
            var corner = bmp.GetPixel(0, 0);
            Console.WriteLine($"Corner pixel: R={corner.R}, G={corner.G}, B={corner.B}, A={corner.A}");
        }
    }
}
