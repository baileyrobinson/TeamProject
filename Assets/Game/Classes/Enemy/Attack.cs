using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    
    Animator _animator;
    GameObject _player;

    
    private bool _collidedWithPlayer;

    void Awake()

    {
       _player = GameObject.FindGameObjectWithTag("Player");
       _animator = GetComponent<Animator>();

    }

    void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject == _player)

        {

            _animator.SetBool("NearPlayer", true);

        }

        print("enter trigger with _player");

    }
    void OnTriggerExit(Collider other)

    {

        if (other.gameObject == _player)

        {

            _animator.SetBool("NearPlayer", false);

        }

        print("exit trigger with _player");

    }

 

    void Attacks()

    {

        if (_collidedWithPlayer)

        {
            
            print("player has been hit");

        }

    }

}


// Use this for initialization
  

