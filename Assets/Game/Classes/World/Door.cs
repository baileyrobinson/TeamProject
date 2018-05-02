using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    void OnTriggerEnter(Collision Player)
    {

        Player.gameObject.GetComponent<Opendoor>().LowerDoor = false;
        
    }
}
