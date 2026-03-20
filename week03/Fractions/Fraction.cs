public class Fraction
{
    private int topNumber;
    private int bottomNumber;

    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }

    public Fraction(int top)
    {
        topNumber = top;
        bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
    }

    public int GetTopNumber()
    {
        return topNumber;
    }

    public int GetBottomNumber()
    {
        return bottomNumber;
    }

    public void SetTopNumber(int top)
    {
        topNumber = top;
    }

    public void SetBottomNumber(int bottom)
    {
        bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        return $"{topNumber}/{bottomNumber}";
    }

    public double GetDecimalValue()
    {
        return (double)topNumber / bottomNumber;
    }
}