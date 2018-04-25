using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
    static public int Materials = 0;
    static public int Money = 0;
    static public int WeaponLevel = 1;
    public Text gold;
    public Text material;
    public Text weaponlevel;

    void Update()
    {
        gold.text = "Gold: " + Money.ToString();
        material.text = "Materials: " + Materials.ToString();
        weaponlevel.text = "Weapon: " + WeaponLevel.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Gold")
        {
            Money += 100;
        }

        if (collision.transform.tag == "Material")
        {
            Materials += 100;
        }
    }
}

