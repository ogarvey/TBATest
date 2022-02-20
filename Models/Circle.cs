using System.Drawing;
using TBATest.Interfaces;

namespace TBATest.Models
{
  public class Circle : IShape
  {
    private Point Origin { get; set; }
    private int Radius { get; set; }

    public Circle(Point origin, int radius)
    {
      Origin = origin;
      Radius = radius;
    }

    public void Translate(int x, int y)
    {
      Origin = new Point(Origin.X + x, Origin.Y + y);
    }

    public void Scale(int resizeBy, char? dimension)
    {
        Radius += resizeBy;
    }

    public void Rotate(int rotateBy)
    {
      Console.WriteLine($"Rotating by {rotateBy} degrees");
    }

    public override string ToString()
    {
      return $"CIRC({Origin.X} {Origin.Y}, {Radius})";
    }
  }
}