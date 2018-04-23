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
        if (Money >= 100 && Materials >= 100)
        {
            WeaponLevel = 2;
            Debug.Log("You have clicked the button!");

            Materials -= 100;
            Money -= 100;
        }
    }
}
