using JetBrains.Annotations;
using UnityEngine;

public class Chessman : MonoBehaviour
{
    //References
    public GameObject controller;
    public GameObject movePlate;

    //Positions
    private int xBoard = -1;
    private int yBoard = -1;

    //Variable to keep track of black player or white player
    private string player;

    //References for all the spirtes that the chesspiece can be
    public Sprite blackQueen, blackKnight, blackBishop, blackKing, blackRook, blackPawn;
    public Sprite whiteQueen, whiteKnight, whiteBishop, whiteKing, whiteRook, whitePawn;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        //take the instantioned location and adjust the transform
        SetCoords();

        switch(this.name)
        {
            case "blackQueen": this.GetComponent<SpriteRenderer>().sprite = blackQueen;
                break;
            case "blackKnight": this.GetComponent<SpriteRenderer>().sprite = blackKnight;
                break;
            case "blackBishop": this.GetComponent<SpriteRenderer>().sprite = blackBishop;
                break;
            case "blackKing": this.GetComponent<SpriteRenderer>().sprite = blackKing;
                break;
            case "blackRook": this.GetComponent<SpriteRenderer>().sprite = blackRook;
                break;
            case "blackPawn": this.GetComponent<SpriteRenderer>().sprite = blackPawn;
                break;

            case "whiteQueen": this.GetComponent<SpriteRenderer>().sprite = whiteQueen;
                break;
            case "whiteKnight": this.GetComponent<SpriteRenderer>().sprite = whiteKnight;
                break;
            case "whiteBishop": this.GetComponent<SpriteRenderer>().sprite = whiteBishop;
                break;
            case "whiteKing": this.GetComponent<SpriteRenderer>().sprite = whiteKing;
                break;
            case "whiteRook": this.GetComponent<SpriteRenderer>().sprite = whiteRook;
                break;
            case "whitePawn": this.GetComponent<SpriteRenderer>().sprite = whitePawn;
                break;
        }
    }
    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;

        x *= 0.66f;
        y *= 0.66f;

        x += 2.3f;
        y += 2.3f;

        this.transform.position = new Vector3(x, y, -1.0f);
    }

    public int GetXBoard()
    {
        return xBoard;
    }

    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard(int x)
    {
        xBoard = x;
    }

    public void SetYBoard(int y)
    {
        yBoard = y;
    }



}


