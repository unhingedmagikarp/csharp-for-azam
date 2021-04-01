using System;
using System.Windows;
using GreenFox;

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw a box that has different colored lines on each edge
            //top line
            var startPoint1 = new Point(200, 100);
            var endPoint1 = new Point(600, 100);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(startPoint1, endPoint1);

            //bottom line
            var startPoint2 = new Point(200, 300);
            var endPoint2 = new Point(600, 300);
            foxDraw.SetStrokeColor(Colors.IndianRed);
            foxDraw.DrawLine(startPoint2, endPoint2);

            //left line
            var startPoint3 = new Point(200, 100);
            var endPoint3 = new Point(200, 300);
            foxDraw.SetStrokeColor(Colors.AntiqueWhite);
            foxDraw.DrawLine(startPoint3, endPoint3);

            //right line
            var startPoint4 = new Point(600, 100);
            var endPoint4 = new Point(600, 300);
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.DrawLine(startPoint4, endPoint4);
        }
    }
}
