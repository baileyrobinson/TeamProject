using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    static public int currentHealth;

    // Use this for initialization
    void Start () {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TakeDamage(int value)
    {
        currentHealth -= value;
        if(currentHealth <= 0)
        {
            GameObject.Destroy(this);
        }
    }
}
