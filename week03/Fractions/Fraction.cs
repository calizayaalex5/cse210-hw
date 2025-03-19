public class Fraction

{
    private int _numerator;
    private int _denomintor;

    public Fraction()
    {
        _numerator = 1;
        _denomintor = 1;
    }     
    
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denomintor = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denomintor = denominator;
    }
    public string GetFractionString()
    {
        string text = $"{_numerator} / {_denomintor}";
        return text;
    }
    
    public double GetDecimalValue()
    
    {
        return (double)_numerator / (double)_denomintor; 
    }

}