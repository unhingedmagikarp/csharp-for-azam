using System;
using System.Windows;
using GreenFox;

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that takes 3 parameters and draws one square
            // Parameters: the x and y coordinates of the square's top left corner and the foxDraw
            // The function shall draw a 50x50 square from that point
            // Draw 3 squares with that function
            // Avoid code duplication!
            Draw3Squares(0, 212, foxDraw, canvas);
            Draw3Squares(15, 110.1, foxDraw, canvas);
            Draw3Squares(45, 380, foxDraw, canvas);
        }
        private void Draw3Squares(double x, double y, FoxDraw foxDraw, Canvas canvas)
        {
            for (int i = 0; i <= 3; i++)
            {
                foxDraw.SetStrokeColor(Colors.Red);
                foxDraw.DrawRectangle(x, y / 2, 50, 50);
            }
        }
    }
}
