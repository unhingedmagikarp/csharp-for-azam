using System;
using System.Windows;
using GreenFox;

namespace RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a square drawing function that takes 3 parameters
            // (the square size and the fill color and the foxDraw)
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).
            SquareSurroundedByRainbowSquares(20, "White", foxDraw, canvas);
        }
        private void SquareSurroundedByRainbowSquares(double size, string fillColor, FoxDraw foxDraw, Canvas canvas)
        {
            // Center the square
            double sizeDoubled = size * 2;
            double halfOfWidth = canvas.Width / 2;
            double halfOfHeight = canvas.Height / 2;
            double x = halfOfWidth - size / 2;
            double y = halfOfHeight - size / 2;
            // Added another red because i couldnt figure out how to display it...
            string[] rainbowColors = { "Red", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            string[] reversedRainbow = rainbowColors.Reverse().ToArray();

            for (int i = reversedRainbow.Length - 1; i >= 0; i--)
            {
                double xI = halfOfWidth - sizeDoubled / 2 * i;
                double yI = halfOfHeight - sizeDoubled / 2 * i;

                string color = rainbowColors[i];
                foxDraw.SetFillColor(Color.Parse(color));

                foxDraw.DrawRectangle(xI, yI, sizeDoubled * i, sizeDoubled * i);
                Console.WriteLine(color);
            }

            //Fill up the first square from user
            foxDraw.SetFillColor(Color.Parse(fillColor));
            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}
