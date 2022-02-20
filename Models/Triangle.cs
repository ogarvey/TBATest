using System.Drawing;
using TBATest.Interfaces;

namespace TBATest.Models
{
  public class Triangle : IShape
  {
    private Point A { get; set; }
    private Point B { get; set; }
    private Point C { get; set; }

    public Triangle(Point a, Point b, Point c)
    {
      A = a;
      B = b;
      C = c;
    }
    public void Translate(int x, int y)
    {
      A = new Point(A.X + x, A.Y + y);
      B = new Point(B.X + x, B.Y + y);
      C = new Point(C.X + x, C.Y + y);
    }

    public void Scale(int resizeBy, char? dimension)
    {
      Console.WriteLine($"Scaling the {dimension} by {resizeBy} degrees");
    }

    public void Rotate(int rotateBy)
    {
      Console.WriteLine($"Rotating by {rotateBy} degrees");
      // Further reading: https://moviecultists.com/where-is-the-centroid-of-an-equilateral-triangle,
      // https://stackoverflow.com/questions/60961351/rotating-an-equilateral-triangle-at-its-center
    }

    public override string ToString()
    {
      return $"TRIA({A.X} {A.Y}, {B.X} {B.Y}, {C.X} {C.Y})";
    }
  }
}