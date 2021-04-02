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
            LinesToCenter(20, 20, foxDraw, canvas);
        }
        private void LinesToCenter(double x, double y, FoxDraw foxDraw, Canvas canvas)
        {
            var startPoint = new Point(x, y);
            foxDraw.SetStrokeColor(Colors.PaleGreen);
            for (int i = 0; i <= 50; i++)
            {
                var startPointRepeated = new Point(x + 20 * i, y + 20 * i);
                foxDraw.SetStrokeColor(Colors.LightBlue);
                var endPointRepeated = new Point(canvas.Width / 2, canvas.Height / 2);
                foxDraw.DrawLine(startPointRepeated, endPointRepeated);
            }
            //! Center of point
            var centerPoint = new Point(canvas.Width / 2, canvas.Height / 2);
            foxDraw.DrawLine(startPoint, centerPoint);
        }
    }
}
