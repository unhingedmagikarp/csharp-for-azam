using System;
using System.Windows;
using GreenFox;

namespace Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Fill the canvas with a checkerboard pattern
            int rowSize = 8;
            int colSize = 8;
            double size = 50;
            double location = 50;
            for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        foxDraw.SetFillColor(Colors.White);
                        foxDraw.DrawRectangle(location * row, location * col, size, size);
                    }
                    else
                    {
                        foxDraw.SetFillColor(Colors.Black);
                        foxDraw.DrawRectangle(location * row, location * col, size, size);
                    }
                }
            }
        }
    }
}
