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
            transform.position += new Vector3(moveH * speed * Time.deltaTime, 0f);
            if (Input.GetKeyDown(KeyCode.Space) && grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
            }
        }
    }
}
