/// <summary>
/// Represents a fraction with a numerator and denominator.
/// This is more accurate than storing numbers in a double.
/// </summary>
using System;
class Fraction
{
    private int _numer;
    private int _denom;

    public Fraction()
    {
        _numer = 1;
        _denom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numer = wholeNumber;
        _denom = 1;
    }

    public Fraction(int numer, int denom)
    {
        _numer = numer;
        _denom = denom;
    }

    public int GetNumer()
    {
        return _numer;
    }

    public void SetNumber(int numer)
    {
        _numer = numer;
    }

    public int GetDenom()
    {
        return _denom;
    }

    public void SetDenom(int denom)
    {
        _denom = denom;
    }

    public string GetFractionString()
    {
        string representation = $"{_numer} / {_denom}";
        return representation;
    }

    public double GetDecimalValue()
    {
        double value = (double)_numer / (double)_denom;
        return value;
    }

}