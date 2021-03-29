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

        }
    }
}
