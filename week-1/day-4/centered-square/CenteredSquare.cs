using System;
using System.Windows;
using GreenFox;

namespace CenteredSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);  
            // Draw a green 10x10 square to the canvas' center

        }
    }
}
