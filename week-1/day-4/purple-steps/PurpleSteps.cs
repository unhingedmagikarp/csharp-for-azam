using System;
using System.Windows;
using GreenFox;

namespace PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Reproduce this:
            // [https://github.com/green-fox-academy/teaching-materials/blob/master/workshop/drawing/assets/r3.png]
            DrawStairCase(15, 20, foxDraw);
        }
        private void DrawStairCase(int sizeOfStairCase, double sizeOfBox, FoxDraw foxDraw)
        {
            for (int i = 0; i <= sizeOfStairCase; i++)
            {
                double xy = 20 + sizeOfBox * i;
                foxDraw.SetStrokeColor(Colors.HotPink);
                foxDraw.SetStrokeThicknes(1);
                foxDraw.SetFillColor(Colors.BlanchedAlmond);
                foxDraw.DrawRectangle(xy, xy, sizeOfBox, sizeOfBox);
            }
        }
    }
}
