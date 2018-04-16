﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon1 : MonoBehaviour {
    int Level = PlayerInventory.WeaponLevel;
    int BaseDamage = 10;
    int damage = 0;

    void dealDamage()
    {
        if (PlayerInventory.WeaponLevel <= 9)
        {
            for (int i = 0; i <= Level; i++)
            {
                damage += BaseDamage;
            }
        }
        if (PlayerInventory.WeaponLevel >= 10)
        {
            damage += BaseDamage *= 15;
        }
        if (PlayerInventory.WeaponLevel >= 15)
        {
            damage += BaseDamage *= 30;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent(EnemyHealth).TakeDamage(damage);
    }
}
