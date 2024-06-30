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

                bool isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);

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
    }
}