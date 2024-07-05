using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePrefab : MonoBehaviour
{
    public Color whiteCol, blackCol;
    public PiecePrefab piecePrefab;

    public void Init(bool isWhite) {
        GetComponent<SpriteRenderer>().color = isWhite ? whiteCol : blackCol;
    }

    public void PlacePiece(Piece piece) {
        var pos = GetComponent<Transform>().transform.position;
        pos.z -= 1;
        var p = Instantiate(piecePrefab, pos, Quaternion.identity);
        p.Init(piece);
    }
}