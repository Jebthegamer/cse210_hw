public class Square : Shape
{
    private double _side { get; set; }
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}