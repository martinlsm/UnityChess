using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePrefab : MonoBehaviour
{
    public Color whiteCol, blackCol;

    public void Init(bool isWhite) {
        GetComponent<SpriteRenderer>().color = isWhite ? whiteCol : blackCol;
    }
}