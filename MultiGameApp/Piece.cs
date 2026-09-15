using System;

namespace BoardGameFramework;

// Piece abstract class
public abstract class Piece
{
    // require every piece to provide a display value
    public abstract string DisplayValue();

    // require every piece to state whether it can be reused
    public abstract bool IsReusable();
}

// NumberPiece inherits from Piece
public class NumberPiece : Piece
{
    // store the number as an integer
    private readonly int _value;

    public NumberPiece(int value)
    {
        _value = value;
    }

    public int Value
    {
        get { return _value; }
    }

    // when display value is requested
    // convert the number to text
    // return the text
    public override string DisplayValue()
    {
        string displayedNumber = _value.ToString();

        return displayedNumber;
    }

    // when checking if the piece is reusable
    // return false
    public override bool IsReusable()
    {
        return false;
    }
}

// MarkPiece inherits from Piece
public class MarkPiece : Piece
{
    // store the mark as a string, such as "X" or "O"
    private readonly string _symbol;

    // the game assigns the symbol during setup/construction
    // this validation prevents an invalid game configuration
    public MarkPiece(string symbol)
    {
        // when creating a MarkPiece
        // check that the symbol is not empty
        // store the symbol

        if (string.IsNullOrWhiteSpace(symbol))
        {
            throw new ArgumentException("The symbol cannot be empty", nameof(symbol));
        }

        _symbol = symbol;
    }

    public string Symbol
    {
        get { return _symbol; }
    }

    // when display value is requested
    // return the symbol

    public override string DisplayValue()
    {
        return _symbol;
    }

    // when checking if the piece is reusable
    // return true

    public override bool IsReusable()
    {
        return true;
    }
}
