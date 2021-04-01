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
            UpperLeftShouldBeGreen();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that draws a single line
            // Use this function to draw the canvas' diagonals
            // If the line starts from the upper-left corner it should be green, otherwise it should be red
            // Make decision about the color in the function
            
        }
        private void UpperLeftShouldBeGreen()
        {
            var upperLeftPoint = new Point(0, 0);
            var startPoint1 = new Point(0, 0);
            var endPoint1 = new Point(canvas.Width, canvas.Height);
            foxDraw.SetStrokeColor(startPoint1.Equals(upperLeftPoint) ? Colors.Green : Colors.Red);
            foxDraw.DrawLine(startPoint1, endPoint1);
        }
    }
}
