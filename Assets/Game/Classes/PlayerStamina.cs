using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStamina : MonoBehaviour {

    public int startingStamina = 100;                            // The amount of stamina the player starts the game with.
    public float currentStamina;                                   // The current stamina the player has.
    public Slider staminaSlider;                                 // Reference to the UI's stamina bar.
    public float speed = 25;

    void Awake()
    {
        currentStamina = startingStamina;
    }


    void Update()
    {

    }

    public void TakeDamage(float amount)
    {
        currentStamina -= amount;
        staminaSlider.value = currentStamina;

        // If the player has lost all it's stamina and the death flag hasn't been set yet...
        if (currentStamina <= 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
