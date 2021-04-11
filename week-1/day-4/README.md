# Drawing and Graphics

*Draw on a canvas using our previous knowledge about control flow and functions*

## Purpose

The main purpose of this workshop is practicing control flow in a more complex
context. It is easier to understand the mechanism of loops and conditionals if
it appears visually on the screen. Also, the workshop adds a simple abstraction
layer by introducing drawing. The participant has to understand the methods of a
graphics library. Therefore, build the habit of processing documentation while
practicing knowledge about the basic building blocks.

## Materials

| Material                                                                                                                |                             Time |
| :---------------------------------------------------------------------------------------------------------------------- | -------------------------------: |
| [WPF Introduction](https://www.youtube.com/watch?v=ImH_LvRMISw)                                                         |                             9:10 |
| [Avalonia](https://avaloniaui.net)                                                                                      |                     Example only |
| [Shapes and Basic Drawing in WPF][basic-drawing-in-wpf]                                                                 | Till `Using Path and Geometries` |
| [Line](https://docs.microsoft.com/en-us/dotnet/api/system.windows.shapes.line?view=netframework-4.7#Examples)           |                     Example only |
| [Ellipse](https://docs.microsoft.com/en-us/dotnet/api/system.windows.shapes.ellipse?view=netframework-4.7#Examples)     |                     Example only |
| [Rectangle](https://docs.microsoft.com/en-us/dotnet/api/system.windows.shapes.rectangle?view=netframework-4.7#Examples) |                     Example only |
| [Polygon](https://docs.microsoft.com/en-us/dotnet/api/system.windows.shapes.polygon?view=netframework-4.7#Examples)     |                     Example only |

## Material Review

- WPF / Avalonia
- Canvas
- Stroke, StrokeThickness, Fill
- Line
- Ellipse
- Rectangle
- Polygon
- Point

## Workshop

For drawing workshop we will be using Avalonia, what is WPF like crossplatform
solution.
For windows user, you can simply install extension for Visual Studio here:
[Avalonia exension](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.AvaloniaforVisualStudio).
In case of MacOS users, folow setup guide from [Setup guide](https://avaloniaui.net/docs/quickstart/create-new-project)
or use blank drawing app template [AvaloniaTemplate](./AvaloniaTemplate).

### WPF / Avalonia

```xml
<Window xmlns="https://github.com/avaloniaui"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d" d:DesignWidth="800" d:DesignHeight="450"
        x:Class="DrawingApplication.MainWindow"
        Title="DrawingApplication">
  <Grid>
    <Canvas Name="canvas"></Canvas>
  </Grid>
</Window>
```

```csharp
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
```

### Lines

```csharp
public static void DrawGreenLines(FoxDraw foxDraw)
{
    foxDraw.SetStrokeColor(Colors.Green);
    foxDraw.DrawLine(0, 10, 100, 10);

    var startPoint = new Point(0, 20);
    var endPoint = new Point(100, 20);
    foxDraw.DrawLine(startPoint, endPoint);
}
```

### Ellipse

```csharp
public static void DrawEllipse(FoxDraw foxDraw)
{
    foxDraw.DrawEllipse(10, 10, 150, 50);
}
```

### Rectangle

```csharp
public static void DrawRectangle(FoxDraw foxDraw)
{
    foxDraw.DrawRectangle(10, 10, 150, 50);
}
```

### Polygons

```csharp
public static void DrawGreenPolygon(FoxDraw foxDraw)
{
    var points = new List<Point>();
    points.Add(new Point(10, 10));
    points.Add(new Point(40, 210));
    points.Add(new Point(170, 190));
    points.Add(new Point(130, 40));
    foxDraw.SetFillColor(Colors.Green);
    foxDraw.DrawPolygon(points);
}
```

### Exercises

- [Middle lines](line-in-the-middle/LineInTheMiddle.cs)
- [Colored box](colored-box/ColoredBox.cs)
- [Diagonals](diagonals/Diagonals.cs)
- [To the center](go-to-center/GoToCenter.cs)
- [Horizontal](horizontal-lines/HorizontalLines.cs)
- [Square in the center](centered-square/CenteredSquare.cs)
- [Fill with rectangles](four-rectangles/FourRectangles.cs)
- [Square positioning](position-square/PositionSquare.cs)
- [Centered boxes](center-box-function/CenterBoxFunction.cs)
- [Rainbow boxes](rainbow-box-function/RainbowBoxFunction.cs)
- | [Purple steps](purple-steps/PurpleSteps.cs) |
  | :-----------------------------------------: |
  |        ![Purple steps](assets/r3.png)       |
- | [Purple steps 3d](purple-steps-3d/PurpleSteps3d.cs) |
  | :-------------------------------------------------: |
  |          ![Purple steps 3d](assets/r4.png)          |
- [Checkerboard](checkerboard/Checkerboard.cs)
- [Everything goes to center](function-to-center/FunctionToCenter.cs)
- [Connect the dots](connect-the-dots/ConnectTheDots.cs)
- [Starry night](starry-night/StarryNight.cs)

[basic-drawing-in-wpf]: https://docs.microsoft.com/en-us/dotnet/framework/wpf/graphics-multimedia/shapes-and-basic-drawing-in-wpf-overview

![circles](../../assets/azam.gif)
