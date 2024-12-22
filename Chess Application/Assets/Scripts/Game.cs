using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject chessPiece;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(chessPiece, new Vector3(0, 0, -1), Quaternion.identity);
    }

}
