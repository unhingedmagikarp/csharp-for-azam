using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
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
            CenteredSquare(10, foxDraw, canvas);
        }
        private void CenteredSquare(double size, FoxDraw foxDraw, Canvas canvas)
        {
            // Center the square
            double halfOfWidth = canvas.Width / 2;
            double halfOfHeight = canvas.Height / 2;
            double x = halfOfWidth - size / 2;
            double y = halfOfHeight - size / 2;

            foxDraw.SetFillColor(Colors.Green);
            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}
