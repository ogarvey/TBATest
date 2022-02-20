using System.Drawing;
using TBATest.Interfaces;

namespace TBATest.Models
{
  public class Rectangle : IShape
  {
    public Point Origin { get; private set; }
    public int Width { get; private set; }
    private int Height { get; set; }

    public Rectangle(Point origin, int width, int height)
    {
      Origin = origin;
      Width = width;
      Height = height;
    }

    public void Translate(int x, int y)
    {
      Origin = new Point(Origin.X + x, Origin.Y + y);
    }

    public void Scale(int resizeBy, char? dimension)
    {
      if (dimension.HasValue && dimension == 'x')
      {
        Width += resizeBy;
      }
      else if (dimension.HasValue && dimension == 'y')
      {
        Height += resizeBy;
      }
    }

    public void Rotate(int rotateBy)
    {
      Console.WriteLine($"Rotating by {rotateBy} degrees");
    }

    public override string ToString()
    {
      return $"RECT({Origin.X} {Origin.Y}, {Width} {Height})";
    }
  }
}