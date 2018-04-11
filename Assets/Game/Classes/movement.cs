using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 25;
    public int startingStamina = 100;                            // The amount of stamina the player starts the game with.
    public float currentStamina;                                   // The current stamina the player has.
    public Slider staminaSlider;                                 // Reference to the UI's stamina bar.

    // Use this for initialization
    void Start()
    {
        currentStamina = startingStamina;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift) && currentStamina > 0)
        {
            transform.Translate(speed * 1.5f * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

            currentStamina -= .5f;
            staminaSlider.value = currentStamina;

            // If the player has lost all it's stamina and the death flag hasn't been set yet...
            if (currentStamina <= 0)
            {
                transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
            }
        }
        else
        {
            if (currentStamina < startingStamina)
            {
                currentStamina += .25f;
                staminaSlider.value = currentStamina;
            }
        }

    }
}




