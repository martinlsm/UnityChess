using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePrefab : MonoBehaviour
{
    public Color whiteCol, blackCol;
    public PawnPrefab pawnPrefab;


    public void Init(bool isOffset) {
        GetComponent<SpriteRenderer>().color = isOffset ? blackCol : whiteCol;
    }

    public void PlacePiece(Piece piece) {
        Instantiate(pawnPrefab, GetComponent<Transform>().transform.position, Quaternion.identity);
    }
}