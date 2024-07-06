using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


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

    private bool isDragged = false;
    private Vector3 lastValidPos;

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

        var p = gameObject.transform.position;

        lastValidPos = new Vector3(p.x, p.y, p.z);
    }

    void OnMouseDrag() {
        float zVal = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
     	Vector3 dest = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zVal ));
        transform.position = new Vector3(dest.x, dest.y, dest.z);
        isDragged = true;
    }

    public void OnMouseUp() {
        if (isDragged) {
            var currPos = transform.position;
            var tileX = round(currPos.x);
            var tileY = round(currPos.y);

            if (tileX >= 0 && tileX < Constants.BOARD_WIDTH && tileY >= 0 && tileY < Constants.BOARD_HEIGHT) {
                lastValidPos = new Vector3(round(currPos.x), round(currPos.y), currPos.z);
            }

            transform.position = lastValidPos;
        }
        isDragged = false;
    }

    static int round(double d) {
        if (d >= 0) {
            return (int)(d + 0.5);
        } else {
            return (int)(d - 0.5);
        }
    }
}
