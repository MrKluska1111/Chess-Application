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

}
