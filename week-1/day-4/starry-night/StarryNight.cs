using System;
using System.Windows;
using GreenFox;

namespace StarryNight
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)
            for (int i = 0; i < 999; i++)
            {

                var random = new Random();
                var randomSize = random.Next(1, 4);
                var randomLocationX = random.Next(1, 800);
                var randomLocationY = random.Next(1, 400);

                string[] starColors = { "White", "AntiqueWhite", "Aqua", "Azure", "WhiteSmoke", "NavajoWhite", "FloralWhite" };

                var randomColor = random.Next(0, starColors.Length);

                foxDraw.SetStrokeColor(Color.Parse($"{starColors[randomColor]}"));
                foxDraw.SetStrokeThicknes(0);
                foxDraw.SetFillColor(Color.Parse($"{starColors[randomColor]}"));
                foxDraw.DrawRectangle(randomLocationX, randomLocationY, randomSize, randomSize);
            }
        }
    }
}
