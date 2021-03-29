using System;
using System.Windows;
using GreenFox;

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw four different size and color rectangles
            // Avoid code duplication!

        }
    }
}
