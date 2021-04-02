using System;
using System.Windows;
using GreenFox;

namespace LineInTheMiddle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a red horizontal line to the canvas' middle
            // draw a green vertical line to the canvas' middle
            var startPoint1 = new Point(0, canvas.Height / 2);
            var endPoint1 = new Point(canvas.Width, canvas.Height / 2);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(startPoint1, endPoint1);

            var startPoint2 = new Point(canvas.Width / 2, 0);
            var endPoint2 = new Point(canvas.Height, canvas.Width / 2);
            foxDraw.SetStrokeColor(Colors.IndianRed);
            foxDraw.DrawLine(startPoint2, endPoint2);
        }
    }
}
