using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpgradeButton : PlayerInventory
{

    public Button upgradebutton;

    void Start()
    {
        Button btn = upgradebutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        WeaponLevel = 2;
        Debug.Log("You have clicked the button!");
    }
}
