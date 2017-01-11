using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

    Animator anim;
    public bool opened;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
	    if(Input.GetKeyDown(KeyCode.E))
        {
            if(!opened)
            {
                opened = !opened;
                anim.SetBool("Opened", true);
            }
            else
            {
                opened = !opened;
                anim.SetBool("Opened", false);
            }
        }
	}
}
