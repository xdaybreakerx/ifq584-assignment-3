namespace MultiGameApp; 

using System.Collections.Generic;

// Player abstract class
// store the player id as an integer
// store the player name as text
// store the pieces currently available to the player

// when a Player is created with an id, name, and collection of pieces
    // store the supplied id
    // store the supplied name
    // store the supplied collection of pieces

// when the player id is requested
    // return the stored id

// when the player name is requested
    // return the stored name

// when the available pieces are requested
    // return the available pieces

// when checking whether the player has a piece
    // return whether the available pieces contain the requested piece

// when using a piece
    // if the player does not have the requested piece
        // return false
    // if the piece cannot be reused
        // remove it from the available pieces
    // return true

// when restoring a piece
    // if the piece cannot be reused and is not already available
        // add it to the available pieces

// require every player to state whether it is computer controlled


// HumanPlayer inherits from Player
// inherit the player id, name, and available pieces

// when checking whether the human player is computer controlled
    // return false


// ComputerPlayer inherits from Player
// inherit the player id, name, and available pieces
// store a move-selection strategy

// when a ComputerPlayer is created with an id, name, pieces, and strategy
    // initialise the inherited player state
    // store the supplied strategy

// when choosing a move for a game
    // ask the strategy to choose a move for this player from the supplied game
    // the strategy prefers an immediate winning move and otherwise selects a random valid move
    // return the selected move

// when checking whether the computer player is computer controlled
    // return true
