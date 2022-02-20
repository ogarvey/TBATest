// See https://aka.ms/new-console-template for more information
using TBATest.Helpers;
using TBATest.Interfaces;
using TBATest.Models;

var parsedList = new List<IShape>();
var left = int.MaxValue;
var index = 0;
var leftMost = 0;

Console.WriteLine("Shapes Exercise");
Console.WriteLine("Reading input file...");


// Read input file from program folder
using var inputStreamReader = File.OpenText("Shapes.txt");

while (!inputStreamReader.EndOfStream)
{
  var inputLine = inputStreamReader.ReadLine();
  var parsedShape = ShapeParser.Parse(inputLine);
  parsedList.Add(parsedShape);
}

parsedList.ForEach(s => {
  // 1. Move all squares 5 units to the right
  if(s is Rectangle) {
    s.Translate(5,0);
  }

  // 2.	Increase the diameter of all circles by 2 units = increase radius by 1
  if(s is Circle) {
    s.Scale(1);
  }

  // 3.	Move all shapes 2 units up, and 2 units to the left
  s.Translate(-2, 2);
  
  // 4.	Rotate the triangle 45° clockwise around its centre
  if (s is Triangle) {
    s.Rotate(45);
  }

  // track left most rectangle after other modifications made
  if (s is Rectangle) {
    var r = s as Rectangle;
    if (r.Origin.X < left) {
      left = r.Origin.X;
      leftMost = index;
    }
  }
  index++;
});

// 5.	Double the width of the left-most square, turning it into a rectangle
var existingWidth = (parsedList[leftMost] as Rectangle).Width;
parsedList[leftMost].Scale(existingWidth, 'x');

// Write output file to program folder
using var outputStreamWriter = new StreamWriter("Modified.txt");
foreach (var shape in parsedList)
{
  outputStreamWriter.WriteLine(shape);
}
