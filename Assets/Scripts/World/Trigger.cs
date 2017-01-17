using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

    Animator animGate;
    Animator animTrigger;

    bool opened = false;

	void Start () {
        animGate = GameObject.Find("Platform").GetComponent<Animator>();
        animTrigger = GameObject.Find("Trigger").GetComponent<Animator>();
	}
	
	void Update () {
        if (animTrigger.GetCurrentAnimatorStateInfo(0).IsName("TriggerOpen"))
        {
            animGate.SetBool("Opened", true);
        }
        else if (animTrigger.GetCurrentAnimatorStateInfo(0).IsName("TriggerClose"))
        {
            animGate.SetBool("Opened", false);
        }
	}

    void OnMouseDown()
    {
        if (!opened)
        {
            opened = !opened;
            animTrigger.SetBool("Opened", true);
        }
        else
        {
            opened = !opened;
            animTrigger.SetBool("Opened", false);
        }
    }
}
