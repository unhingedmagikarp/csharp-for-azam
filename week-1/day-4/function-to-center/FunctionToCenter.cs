using System;
using System.Windows;
using GreenFox;

namespace FunctionToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that takes 3 parameters and draws a single line
            // Parameters: the x and y coordinates of the line's starting point and the foxDraw
            // The function shall draw a line from that point to the center of the canvas
            // Fill the canvas with lines from the edges (every 20 px) to the center

        }
    }
}
