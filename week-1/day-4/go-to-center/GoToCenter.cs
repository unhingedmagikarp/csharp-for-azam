using System;
using System.Windows;
using GreenFox;

namespace GoToCenter
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
            // Draw at least 3 lines with that function using a loop

            // --- Have to pass canvas as well --- 
            Draw3Lines(0, 0, foxDraw, canvas);
            Draw3Lines(11.1, 13, foxDraw, canvas);
            Draw3Lines(20, 45, foxDraw, canvas);

        }
        private void Draw3Lines(double x, double y, FoxDraw foxDraw, Canvas canvas)
        {
            for (int i = 1; i < 3; i++)
            {
                var startPoint1 = new Point(x, y);
                var endPoint1 = new Point(canvas.Width / 2, canvas.Height / 2);
                foxDraw.SetStrokeColor(Colors.Red);
                foxDraw.DrawLine(startPoint1, endPoint1);

            }
        }
    }
}
