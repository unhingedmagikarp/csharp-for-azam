using System;
using System.Windows;
using GreenFox;

namespace PurpleSteps3d
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Reproduce this:
            // [https://github.com/green-fox-academy/teaching-materials/blob/master/workshop/drawing/assets/r4.png]
            DrawStairCaseScaling(10, 20, foxDraw);

        }
        private void DrawStairCaseScaling(int sizeOfStairCase, double size, FoxDraw foxDraw)
        {
            double position = size;
            for (int i = 0; i <= sizeOfStairCase; i++)
            {
                double scaleForXY = position + size * (i - 1);
                double sizeScaled = size * i;
                //Position XY end
                position += size * (i - 1);

                foxDraw.SetStrokeColor(Colors.HotPink);
                foxDraw.SetStrokeThicknes(1);
                foxDraw.SetFillColor(Colors.BlanchedAlmond);
                foxDraw.DrawRectangle(scaleForXY, scaleForXY, sizeScaled, sizeScaled);
                //double boxbox = sizeOfBox += i *2;
                //double xy = (20 * i) * 2 + sizeOfBox;

                //foxDraw.SetStrokeColor(Colors.HotPink);
                //foxDraw.SetStrokeThicknes(1);
                //foxDraw.SetFillColor(Colors.BlanchedAlmond);

                //foxDraw.DrawRectangle(xy, xy, boxbox, boxbox);
            }
        }
    }
}
