
using System.Dynamic;

/// <summary>
/// Represents a fraction with a numerator and denominator.
/// This is more accurate than storing numbers in a double.
/// </summary>
public class Fraction
{
    // numerator attribute
    private int _numer;

    // denominator attribute
    private int _denom;

    // Default Constructor
    public Fraction()
    {
        _numer = 1;
        _denom = 1;
    }

    // Second Constructor: Whole numbers
    public Fraction(int wholeNumber)
    {
        _numer = wholeNumber;
        _denom = 1;
    }

    // Third Constructor: Allows the user to pass the numerator and the denominator
    public Fraction(int numer, int denom) // make the parameters have a distinct name. If the parameter name is the same as the attribute from earlier in the class, the most local variable (the parameter) wins. This is when we see the "this." keyword. Brother barzee says it's dumb.
    {
        _numer = numer;
        _denom = denom;
    }


    // Numerator Getter
    public int GetTop()
    {
        return _numer;
    }

    // Numerator Setter
    public void SetTop(int numer)
    {
        _numer = numer;
    }

    // Denomenator Getter
    public int GetBottom()
    {
        return _denom;
    }

    // Numerator Setter
    public void SetBottom(int denom)
    {
        _denom = denom;
    }



    // Get fraction string getter
    public string GetFractionString()
    {
        // this is a simple string representation of the fraction. It does not acctually contain the value of the fraction, technically it's just letters as a string right now.
        string representation = $"{_numer} / {_denom}";

        return representation;

    }


    // Get decimal value getter
    public double GetDecimalValue()
    {
        /*
        This code will do integer division because _numer and _denom were set to the int data type earlier, meaning that youll only get an integer

        double value = _numer / _denom;
        return value;
        */

        // make them doubles for just this calculation
        double value = (double)_numer / (double)_denom;
        return value;
    }


}