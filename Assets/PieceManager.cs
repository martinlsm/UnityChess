using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{
    public PiecePrefab piecePrefab;

    void Start() {
        PlacePieces();
    }

    public void PlacePiece(Piece piece, int x, int y) {
        var pos = new Vector3(x, y, -1);
        var pce = Instantiate(piecePrefab, pos, Quaternion.identity);
        pce.Init(piece);
    }

    void PlacePieces() {
        // White pawns
        for (int i = 0; i < Constants.BOARD_WIDTH; i++) {
            PlacePiece(new Piece(PieceType.Pawn, PieceColor.White), i, 1);
        }

        // White pieces
        PlacePiece(new Piece(PieceType.Rook, PieceColor.White), 0, 0);
        PlacePiece(new Piece(PieceType.Knight, PieceColor.White), 1, 0);
        PlacePiece(new Piece(PieceType.Bishop, PieceColor.White), 2, 0);
        PlacePiece(new Piece(PieceType.Queen, PieceColor.White), 3, 0);
        PlacePiece(new Piece(PieceType.King, PieceColor.White), 4, 0);
        PlacePiece(new Piece(PieceType.Bishop, PieceColor.White), 5, 0);
        PlacePiece(new Piece(PieceType.Knight, PieceColor.White), 6, 0);
        PlacePiece(new Piece(PieceType.Rook, PieceColor.White), 7, 0);

        // Black pawns
        for (int i = 0; i < Constants.BOARD_HEIGHT; i++) {
            PlacePiece(new Piece(PieceType.Pawn, PieceColor.Black), i, 6);
        }

        // Black pieces
        PlacePiece(new Piece(PieceType.Rook, PieceColor.Black), 0, 7);
        PlacePiece(new Piece(PieceType.Knight, PieceColor.Black), 1, 7);
        PlacePiece(new Piece(PieceType.Bishop, PieceColor.Black), 2, 7);
        PlacePiece(new Piece(PieceType.Queen, PieceColor.Black), 3, 7);
        PlacePiece(new Piece(PieceType.King, PieceColor.Black), 4, 7);
        PlacePiece(new Piece(PieceType.Bishop, PieceColor.Black), 5, 7);
        PlacePiece(new Piece(PieceType.Knight, PieceColor.Black), 6, 7);
        PlacePiece(new Piece(PieceType.Rook, PieceColor.Black), 7, 7);
    }
}
