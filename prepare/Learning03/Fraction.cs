public class Fraction
{
    private int _top { get; set; }
    private int _bottom { get; set; }

    public Fraction()
    {
        // Default to 0
        _top = 0;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        int top = _top;
        return top;
    }
    public void SetTop(int newTop)
    {
        _top = newTop;
    }

    public int GetBottom()
    {
        int bottom = _bottom;
        return bottom;
    }

    public void SetBottom(int newBottom)
    {
        _bottom = newBottom;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
        return decimalValue;
    }

}