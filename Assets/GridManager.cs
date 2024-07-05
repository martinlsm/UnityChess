using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Transform cam;
    public int width, height;
    public TilePrefab tilePrefab;
    public TilePrefab[,] tiles;
    
 
    // Start is called before the first frame update
    void Start() {
        tiles = new TilePrefab[width, height];
        GenerateGrid();
        PlacePieces();

        cam.transform.position = new Vector3((float) width / 2 - 0.5f, (float) height / 2 - 0.5f, -10);
    }

    // Update is called once per frame
    void Update() {

    }

    void GenerateGrid() {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                TilePrefab spawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);

                char file = (char)((int)'A' + x);
                spawnedTile.name = $"{file}{y + 1}";

                bool isWhite = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isWhite);

                tiles[x, y] = spawnedTile;
            }
        }
    }

    void PlacePieces() {
        // White pawns
        for (int i = 0; i < width; i++) {
            Piece piece = new Piece(PieceType.Pawn, PieceColor.White);
            tiles[i, 1].PlacePiece(piece);
        }

        // White pieces
        tiles[0, 0].PlacePiece(new Piece(PieceType.Rook, PieceColor.White));
        tiles[1, 0].PlacePiece(new Piece(PieceType.Knight, PieceColor.White));
        tiles[2, 0].PlacePiece(new Piece(PieceType.Bishop, PieceColor.White));
        tiles[3, 0].PlacePiece(new Piece(PieceType.Queen, PieceColor.White));
        tiles[4, 0].PlacePiece(new Piece(PieceType.King, PieceColor.White));
        tiles[5, 0].PlacePiece(new Piece(PieceType.Bishop, PieceColor.White));
        tiles[6, 0].PlacePiece(new Piece(PieceType.Knight, PieceColor.White));
        tiles[7, 0].PlacePiece(new Piece(PieceType.Rook, PieceColor.White));

        // Black pawns
        for (int i = 0; i < width; i++) {
            Piece piece = new Piece(PieceType.Pawn, PieceColor.Black);
            tiles[i, 6].PlacePiece(piece);
        }

        // Black pieces
        tiles[0, 7].PlacePiece(new Piece(PieceType.Rook, PieceColor.Black));
        tiles[1, 7].PlacePiece(new Piece(PieceType.Knight, PieceColor.Black));
        tiles[2, 7].PlacePiece(new Piece(PieceType.Bishop, PieceColor.Black));
        tiles[3, 7].PlacePiece(new Piece(PieceType.Queen, PieceColor.Black));
        tiles[4, 7].PlacePiece(new Piece(PieceType.King, PieceColor.Black));
        tiles[5, 7].PlacePiece(new Piece(PieceType.Bishop, PieceColor.Black));
        tiles[6, 7].PlacePiece(new Piece(PieceType.Knight, PieceColor.Black));
        tiles[7, 7].PlacePiece(new Piece(PieceType.Rook, PieceColor.Black));
    }
}