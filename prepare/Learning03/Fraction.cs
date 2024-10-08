namespace Learning03;

public class Fraction
{
    private int _top;
    private int _bottom;

    // constructors
    public Fraction()
    {
        _top = 1;
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
    
    // getters and setters
    public int GetTop() => _top;
    public void SetTop(int top) => _top = top;
    public int GetBottom() => _bottom;
    public void SetBottom(int bottom) => _bottom = bottom;
    
    // methods
    public string GetFractionString() => $"{_top}/{_bottom}";
    public double GetDecimalValue() => (double)_top / (double)_bottom;
    
}