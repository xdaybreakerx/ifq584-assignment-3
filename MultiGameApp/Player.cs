using System.Collections.Generic;
using System.Data.Common;

namespace MultiGameApp;

public abstract class Player
{
    private int id;
    private string name;
    private List<Piece> availablePieces;


    protected Player(int id, string name, List<Piece> availablePieces)
    {
        this.id = id;
        this.name = name;
        this.availablePieces = availablePieces;
    }


    public int Id
    {
        get { return id; }
    }

    public string Name
    {
        get { return name; }
    }

    public List<Piece> AvailablePieces
    {
        get { return availablePieces; }
    }


    public bool HasPiece(Piece piece)
    {
        return availablePieces.Contains(piece);
    }

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

    public void RestorePiece(Piece piece)
    {
        if (!piece.IsReusable() && !HasPiece(piece))
        {
            availablePieces.Add(piece);
        }
    }

    public abstract bool IsComputer();
}

public class HumanPlayer : Player
{
    public HumanPlayer(int id, string name, List<Piece> availablePieces)
        : base(id, name, availablePieces) { }

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
