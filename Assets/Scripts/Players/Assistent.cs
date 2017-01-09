using UnityEngine;
using System.Collections;

public class Assistent : MonoBehaviour {

    public float speed = 3f;

    void FixedUpdate()
    {
        if (PlayerController.currentPlayer == gameObject)
        {
            float moveV = Input.GetAxis("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, moveV * speed);
            float moveH = Input.GetAxis("Horizontal");
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveH * speed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
