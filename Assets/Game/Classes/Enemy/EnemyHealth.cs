using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    static public int currentHealth;
    public GameObject Gold;
    public Transform Goldspawn;
    public float dropRate = 1f; //50% drop chance 
    
    // Use this for initialization
    void Start () {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(int value)
    {
        currentHealth -= value;
        if(currentHealth <= 0)
        {
            GameObject.Destroy(this);
            if (Random.Range(0f, 1f) <= dropRate)
            {
                Instantiate(Gold, Goldspawn.position, Goldspawn.rotation);
            }
        }
    }
    
}
