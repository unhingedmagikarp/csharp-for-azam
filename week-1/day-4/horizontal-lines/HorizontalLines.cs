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
            DrawLotsOfLines(0, 212, foxDraw, canvas);
            DrawLotsOfLines(15, 110.1, foxDraw, canvas);
            DrawLotsOfLines(45, 380, foxDraw, canvas);
        }
        private void DrawLotsOfLines(double x, double y, FoxDraw foxDraw, Canvas canvas)
        {
            for (int i = 0; i <= 50; i++)
            {
                var startPoint1 = new Point(x, y);
                var endPoint1 = new Point(canvas.Width, y);
                foxDraw.SetStrokeColor(Colors.Red);
                foxDraw.DrawLine(startPoint1, endPoint1);
            }
        }
    }
}
