using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace ConnectTheDots
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}
            var makeABox = new List<Point>() { };
            makeABox.Add(new Point(10, 10));
            makeABox.Add(new Point(290, 10));
            makeABox.Add(new Point(290, 290));
            makeABox.Add(new Point(10, 290));

            var connectLine = new List<Point>() { };
            connectLine.Add(new Point(50, 100));
            connectLine.Add(new Point(70, 70));
            connectLine.Add(new Point(80, 90));
            connectLine.Add(new Point(90, 90));
            connectLine.Add(new Point(100, 70));
            connectLine.Add(new Point(120, 100));
            connectLine.Add(new Point(85, 130));
            connectLine.Add(new Point(50, 100));

            ConnectTheDots(connectLine, foxDraw);

        }
        private void ConnectTheDots(List<Point> listOfPoints, FoxDraw foxDraw)
        {
            foreach (var point in listOfPoints)
            {
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);
                var startPoint = new Point(point.X, point.Y);
                var endPoint = new Point(point.X, point.Y);
                foxDraw.SetStrokeColor(Colors.White);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
    }
}
