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

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Player")
        {
            gameObject.GetComponent<Opendoor>().LowerDoor = false;
        }
    }
}
