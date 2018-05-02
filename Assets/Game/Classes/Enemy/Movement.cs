using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour {

    private NavMeshAgent _nav;
    private Transform _player;
    private EnemyHealth _enemyHealth;

    // Use this for initialization
    void Start () {
        _nav = GetComponent<NavMeshAgent>();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _enemyHealth = GetComponent<EnemyHealth>();

    }

    // Update is called once per frame
    void Update () {
        if (_enemyHealth.startingHealth > 0)        
        {
            _nav.SetDestination(_player.position);  
        }
        else
        {   
            _nav.enabled = false;  
        }

    }
}
