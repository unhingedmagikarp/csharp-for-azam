using System;
using System.Windows;
using GreenFox;

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw four different size and color rectangles
            // Avoid code duplication!
            string[] colors = { "Red", "Black", "White", "Green" };
            foreach (string color in colors)
            {
                foxDraw.SetFillColor(Color.Parse(color));
            }

            for (int i = 0; i <= 4; i++)
            {
                var rnd = new Random();
                double height = rnd.Next(1, 200);
                double width = rnd.Next(1, 400);

                foxDraw.DrawRectangle(canvas.Width / 2, canvas.Height / 2, width, height);
            }

        }
    }
}
