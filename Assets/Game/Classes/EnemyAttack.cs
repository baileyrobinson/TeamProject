using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float damage = 10f;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
    }
}
