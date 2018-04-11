using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon1 : MonoBehaviour {
    int Level = PlayerInventory.WeaponLevel;
    int BaseDamage = 10;

    void dealDamage()
    {
        if (PlayerInventory.WeaponLevel <= 9)
        {
            for (int i = 0; i <= Level; i++)
            {
                EnemyHealth.currentHealth -= BaseDamage;
            }
        }
        if (PlayerInventory.WeaponLevel == 10)
        {
            EnemyHealth.currentHealth -= BaseDamage *= 15;
        }
    }
}
