using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public static GameObject currentPlayer;

    void Start()
    {
        currentPlayer = player1;
        currentPlayer.GetComponent<SpriteOutline>().outlineSize = 5;
    }
	
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
                player1.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                currentPlayer.GetComponent<SpriteOutline>().outlineSize = 5;
                player1.GetComponent<SpriteOutline>().outlineSize = 0;
            }
            else
            {
                currentPlayer = player1;
                player2.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                currentPlayer.GetComponent<SpriteOutline>().outlineSize = 5;
                player2.GetComponent<SpriteOutline>().outlineSize = 0;
            }
        }
	}
}
