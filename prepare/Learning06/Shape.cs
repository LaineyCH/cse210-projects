namespace learning06;

public abstract class Shape
{
    private string _color;
    private string _name;
    
    public string GetColor() => _color;
    public string SetColor(string color) => _color = color;
    public string GetName() => _name;
    public void SetName(string name) => _name = name;

    protected Shape(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}