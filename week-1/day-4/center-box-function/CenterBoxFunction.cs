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

        }
    }
}
