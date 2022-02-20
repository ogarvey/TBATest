using System.Drawing;
using TBATest.Interfaces;

namespace TBATest.Helpers
{
  public static class ShapeParser
  {
    public static IShape Parse(string input)
    {
      var paramBeginIndex = input.IndexOf('(');
      var shapeType = input.Substring(0, paramBeginIndex);
      var parameters = input.Substring(paramBeginIndex + 1, input.Length - (paramBeginIndex + 2));
      var splitParams = parameters.Split(',');
      switch (shapeType)
      {
        case "RECT":
          return ParseRectangle(splitParams);
        case "CIRC":
          return ParseCircle(splitParams);
        case "TRIA":
          return ParseTriangle(splitParams);
        default:
          throw new Exception("Couldn't parse shape!");
      }
    }

    private static Models.Rectangle ParseRectangle(string[] splitParams)
    {
      var origin = splitParams[0].Split(' ').Select(i => int.Parse(i)).ToList();
      var dimensions = splitParams[1].Trim().Split(' ').Select(i => int.Parse(i)).ToList();
      var width = dimensions[0];
      var height = dimensions[1];
      return new Models.Rectangle(new Point(origin[0], origin[1]), width, height);
    }

    private static Models.Circle ParseCircle(string[] splitParams)
    {
      var origin = splitParams[0].Split(' ').Select(i => int.Parse(i)).ToList();
      var radius = int.Parse(splitParams[1]);
      return new Models.Circle(new Point(origin[0], origin[1]), radius);
    }

    private static Models.Triangle ParseTriangle(string[] splitParams)
    {
      var a = splitParams[0].Split(' ').Select(i => int.Parse(i)).ToList();
      var b = splitParams[1].Trim().Split(' ').Select(i => int.Parse(i)).ToList();
      var c = splitParams[2].Trim().Split(' ').Select(i => int.Parse(i)).ToList();
      return new Models.Triangle(new Point(a[0], a[1]), new Point(b[0], b[1]), new Point(c[0], c[1]));
    }
  }
}