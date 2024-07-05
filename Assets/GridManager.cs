using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Transform cam;
    public TilePrefab tilePrefab;
    public TilePrefab[,] tiles;
    
 
    // Start is called before the first frame update
    void Start() {
        tiles = new TilePrefab[Constants.BOARD_WIDTH, Constants.BOARD_HEIGHT];
        GenerateGrid();

        cam.transform.position = new Vector3((float) Constants.BOARD_WIDTH / 2 - 0.5f, (float) Constants.BOARD_HEIGHT / 2 - 0.5f, -10);
    }

    void GenerateGrid() {
        for (int x = 0; x < Constants.BOARD_WIDTH; x++) {
            for (int y = 0; y < Constants.BOARD_HEIGHT; y++) {
                TilePrefab spawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);

                char file = (char)((int)'A' + x);
                spawnedTile.name = $"{file}{y + 1}";

                bool isWhite = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isWhite);

                tiles[x, y] = spawnedTile;
            }
        }
    }

}