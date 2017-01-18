using UnityEngine;
using System.Collections;

public class Joiner : MonoBehaviour {

    GameObject player;

	void Start () {
        player = GameObject.Find("Player1");
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if(hit.collider.name.Contains("Platform"))
                {
                    player.GetComponent<DistanceJoint2D>().enabled = true;
                    Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    pz.z = 0;
                    player.GetComponent<DistanceJoint2D>().connectedAnchor = new Vector2(pz.x, pz.y);
                }
            }
        }
	}
}
