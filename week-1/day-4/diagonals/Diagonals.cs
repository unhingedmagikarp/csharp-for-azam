using System;
using System.Windows;
using GreenFox;

namespace Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that draws a single line
            // Use this function to draw the canvas' diagonals
            // If the line starts from the upper-left corner it should be green, otherwise it should be red
            // Make decision about the color in the function
        }
    }
}
