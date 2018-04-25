using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    private EnemyManager _spawnManager;

    public int startingHealth = 100;// The amount of health the player starts the game with.
    static public int currentHealth;
    public GameObject enemy;
    public GameObject Gold;
    public Transform Goldspawn;
    public float dropRate = 1f; //70% drop chance 
    
    // Use this for initialization
    void Start () {
        _spawnManager = GameObject.FindGameObjectWithTag("spawnManager").GetComponent<EnemyManager>();

        currentHealth = startingHealth;
        Death();
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
    public void Death()
    {
        GameObject.Destroy(enemy);
        _spawnManager.enemyDefeated();
        //if (Random.Range(0f, 1f) <= dropRate)
        //{
        //    Instantiate(Gold, Goldspawn.position, Goldspawn.rotation);
        //}
    }

}
