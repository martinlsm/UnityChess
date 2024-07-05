using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiecePrefab : MonoBehaviour
{
    public Sprite whitePawnSprite;
    public Sprite whiteRookSprite;
    public Sprite whiteKnightSprite;
    public Sprite whiteBishopSprite;
    public Sprite whiteQueenSprite;
    public Sprite whiteKingSprite;

    public Sprite blackPawnSprite;
    public Sprite blackRookSprite;
    public Sprite blackKnightSprite;
    public Sprite blackBishopSprite;
    public Sprite blackQueenSprite;
    public Sprite blackKingSprite;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(Piece piece) {
        if (piece.color == PieceColor.White) {
            switch (piece.type) {
                case PieceType.Rook:
                    GetComponent<SpriteRenderer>().sprite = whiteRookSprite;
                    break;
                case PieceType.Knight:
                    GetComponent<SpriteRenderer>().sprite = whiteKnightSprite;
                    break;
                case PieceType.Bishop:
                    GetComponent<SpriteRenderer>().sprite = whiteBishopSprite;
                    break;
                case PieceType.Queen:
                    GetComponent<SpriteRenderer>().sprite = whiteQueenSprite;
                    break;
                case PieceType.King:
                    GetComponent<SpriteRenderer>().sprite = whiteKingSprite;
                    break;
                case PieceType.Pawn:
                    GetComponent<SpriteRenderer>().sprite = whitePawnSprite;
                    break;
            }
        } else {
            switch (piece.type) {
                case PieceType.Rook:
                    GetComponent<SpriteRenderer>().sprite = blackRookSprite;
                    break;
                case PieceType.Knight:
                    GetComponent<SpriteRenderer>().sprite = blackKnightSprite;
                    break;
                case PieceType.Bishop:
                    GetComponent<SpriteRenderer>().sprite = blackBishopSprite;
                    break;
                case PieceType.Queen:
                    GetComponent<SpriteRenderer>().sprite = blackQueenSprite;
                    break;
                case PieceType.King:
                    GetComponent<SpriteRenderer>().sprite = blackKingSprite;
                    break;
                case PieceType.Pawn:
                    GetComponent<SpriteRenderer>().sprite = blackPawnSprite;
                    break;
            }
        }
    }
}
