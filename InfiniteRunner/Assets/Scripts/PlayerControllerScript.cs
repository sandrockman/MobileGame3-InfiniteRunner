using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        MoveCharacter();
	}

    void MoveCharacter()
    {
        //Bad-ish for mobile; Use this if FixedUpdate
        //if (Input.GetKey(KeyCode.W))
        //    anim.SetBool("Jump", true);
        //else
        //    anim.SetBool("Jump", false);

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Jump", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Jump", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Slide", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("Slide", false);
        }


    }
}
