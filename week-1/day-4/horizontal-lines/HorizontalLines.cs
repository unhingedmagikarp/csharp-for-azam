using System;
using System.Windows;
using GreenFox;

namespace HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that takes 3 parameters and draws a single line
            // Parameters: the x and y coordinates of the line's starting point and the foxDraw
            // The function shall draw a 50 long horizontal line from that point
            // Draw at least 3 lines with that function using a loop

        }
    }
}
