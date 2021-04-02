using System;
using System.Windows;
using GreenFox;

namespace CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that takes 2 parameters and draws one square
            // Parameters: the square size and the graphics
            // The function shall draw a square of that size to the center of the canvas
            // Draw 3 squares with that function
            // (the squares should not be filled otherwise they will hide each other)
            // Avoid code duplication!
            Draw3CenteredSquares(231, foxDraw, canvas);
            Draw3CenteredSquares(15, foxDraw, canvas);
            Draw3CenteredSquares(45, foxDraw, canvas);

        }
        private void Draw3CenteredSquares(double size, FoxDraw foxDraw, Canvas canvas)
        {
            for (int i = 0; i <= 3; i++)
            {
                foxDraw.SetFillColor(Color.FromArgb(0, 220, 20, 60));
                foxDraw.DrawRectangle(canvas.Width / 2, canvas.Height / 2, size, size);
            }
        }
    }
}
