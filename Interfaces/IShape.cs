namespace TBATest.Interfaces;

/// <summary>
///  This interface defines the 3 methods common to all shapes.
/// </summary>
public interface IShape
{
  /// <summary>
  /// Moves the transform by x along the x axis, y along the y axis
  /// Use negative values to move left along x axis, and down y axis
  /// </summary>
  /// <param name="x">Amount to move along x axis.</param>
  /// <param name="y">Amount to move along y axis.</param>
  void Translate(int x, int y);

  /// <summary>
  /// Scales shape in x or y dimension by given amount
  /// </summary>
  /// <param name="resizeBy">Amount to resize by.</param>
  /// <param name="dimension">Dimension (x,y) to resize.</param>
  void Scale(int resizeBy, char? dimension = null);

  /// <summary>
  /// Rotates shape by given degrees
  /// </summary>
  /// <param name="rotateBy">Amount to rotate by (positive for clockwise, negative for anti-clockwise).</param>
  void Rotate(int rotateBy);
}
