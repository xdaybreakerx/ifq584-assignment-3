using System.Collections.Generic;
using System.Data.Common;

namespace MultiGameApp;

// Player abstract class
public abstract class Player
{
    // store the player id as an integer
    // store the player name as text
    // store the pieces currently available to the player
    private int id;
    private string name;
    private List<Piece> availablePieces;

    // when a Player is created with an id, name, and collection of pieces
    // store the supplied id
    // store the supplied name
    // store the supplied collection of pieces
    protected Player(int id, string name, List<Piece> availablePieces)
    {
        this.id = id;
        this.name = name;
        this.availablePieces = availablePieces;
    }

    // when the player id is requested
    // return the stored id
    public int Id
    {
        get { return id; }
    }

    // when the player name is requested
    // return the stored name
    public string Name
    {
        get { return name; }
    }

    // when the available pieces are requested
    // return the available pieces
    public List<Piece> AvailablePieces
    {
        get { return availablePieces; }
    }

    // when checking whether the player has a piece
    // return whether the available pieces contain the requested piece
    public bool HasPiece(Piece piece)
    {
        return availablePieces.Contains(piece);
    }

    // when using a piece
    // if the player does not have the requested piece
    // return false
    // if the piece cannot be reused
    // remove it from the available pieces
    // return true
    public bool UsePiece(Piece piece)
    {
        if (!HasPiece(piece))
        {
            return false;
        }

        if (!piece.IsReusable())
        {
            availablePieces.Remove(piece);
        }

        return true;
    }

    // when restoring a piece
    // if the piece cannot be reused and is not already available
    // add it to the available pieces
    public void RestorePiece(Piece piece)
    {
        if (!piece.IsReusable() && !HasPiece(piece))
        {
            availablePieces.Add(piece);
        }
    }

    // require every player to state whether it is computer controlled
    public abstract bool IsComputer();
}

public class HumanPlayer : Player
{
    // HumanPlayer inherits from Player
    // inherit the player id, name, and available pieces
    public HumanPlayer(int id, string name, List<Piece> availablePieces)
        : base(id, name, availablePieces) { }

    // when checking whether the human player is computer controlled
    // return false
    public override bool IsComputer()
    {
        return false;
    }
}

public class ComputerPlayer : Player
{
    // ComputerPlayer inherits from Player
    // inherit the player id, name, and available pieces
    // store a move-selection strategy

    // when a ComputerPlayer is created with an id, name, pieces, and strategy
    // initialise the inherited player state
    // store the supplied strategy
    public ComputerPlayer(int id, string name, List<Piece> availablePieces)
        // TODO Move Strategy
        : base(id, name, availablePieces)
    {
        // todo move strategy
    }

    // TO DO
    // move function
    // when choosing a move for a game
    // ask the strategy to choose a move for this player from the supplied game
    // the strategy prefers an immediate winning move and otherwise selects a random valid move
    // return the selected move

    // when checking whether the computer player is computer controlled
    // return true
    public override bool IsComputer()
    {
        return true;
    }
}
