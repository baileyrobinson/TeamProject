﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private EnemyManager _spawnManager;
    private Animator _animator;
    public int startingHealth = 100;// The amount of health the player starts the game with.
    static public int currentHealth;
    public GameObject enemy;
    public GameObject Gold;
    public Transform GoldSpawn;
    public GameObject Material;
    public Transform MaterialSpawn;
    
    int damage = 100;


    public float dropRate = .70f; //70% drop chance 
    

    //     // Clone the objects that are "in" the box.
    //     foreach (GameObject item in items)
    //     {
    //         if (item != null)
    //         {
    //             // Add code here to change the position slightly
    //             // so the items are scattered a little bit.
    //             Instantiate(item, position, Quaternion.identity);

    // Use this for initialization
    void Start()
    {
        Vector3 position = transform.position;
        _animator = GetComponent<Animator>();
        _spawnManager = GameObject.FindGameObjectWithTag("spawnManager").GetComponent<EnemyManager>();

        currentHealth = startingHealth;

        //Death();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")

        {

            TakeDamage(damage);
            print("player has been hit");
        }
    }
    public void TakeDamage(int value)
    {
        currentHealth -= value;
        if (currentHealth <= 0)
        {
            
            Death();
        }
    }
    private void Death()
    {
        
        _spawnManager.enemyDefeated();

        if (Random.Range(0f, 1f) <= dropRate)
        {
            Instantiate(Gold, transform.position, GoldSpawn.rotation);
            if (Random.Range(0f, 1f) <= dropRate)
            {
                
                Instantiate(Material, transform.position, MaterialSpawn.rotation);

            }
        }
        GameObject.Destroy(enemy);
    }
    
}
