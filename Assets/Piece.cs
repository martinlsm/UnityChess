public enum PieceType {
    Pawn,
    Rook,
    Knight,
    Bishop,
    Queen,
    King,
}

public enum PieceColor {
    White,
    Black,
}

public class Piece {
    public PieceType type { get; }
    public PieceColor color { get; }

    public Piece(PieceType t, PieceColor col)
    {
        type = t;
        color = col;
    }
}