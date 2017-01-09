using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 3f;
    public float jump = 300f;
    public bool grounded;

    void FixedUpdate()
    {
        if (PlayerController.currentPlayer == gameObject)
        {
            float moveH = Input.GetAxis("Horizontal");
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveH * speed, GetComponent<Rigidbody2D>().velocity.y);
            if (Input.GetKeyDown(KeyCode.Space) && grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
            }
        }
    }
}
