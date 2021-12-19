// See https://aka.ms/new-console-template for more information
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

Console.WriteLine("Hello, World!");

var width = 20;
var height = 20;
var pixels = new byte[4 * width * height];
for (int i = 0; i < 4 * width * height; ++i)
{
    pixels[i] = 0xFF;
}

var rect = new Int32Rect(0, 0, width, height);

var writeableBitmap = new WriteableBitmap(96, 96, 96, 96, PixelFormats.Bgr32, null);
writeableBitmap.WritePixels(rect, pixels, 4, 0, 0);
