using System;
using System.Windows;
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

        }
    }
}
