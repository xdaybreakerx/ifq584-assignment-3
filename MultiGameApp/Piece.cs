// Piece abstract class

// require every piece to provide a display value
// require every piece to state whether it can be reused


// NumberPiece inherits from Piece

// store the number as an integer

// when display value is requested
    // convert the number to text
    // return the text

// when checking if the piece is reusable
    // return false


// MarkPiece inherits from Piece

// store the mark as a string, such as "X" or "O"

// when creating a MarkPiece
    // check that the symbol is not empty
    // store the symbol

// when display value is requested
    // return the symbol

// when checking if the piece is reusable
    // return true