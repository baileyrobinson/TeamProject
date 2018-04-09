using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject player;
    public float speed = 25;
    public int startingStamina = 100;                            // The amount of stamina the player starts the game with.
    public float currentStamina;                                   // The current stamina the player has.
    public Slider staminaSlider;                                 // Reference to the UI's stamina bar.

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && currentStamina > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * 2);

            currentStamina -= Time.deltaTime;
            staminaSlider.value = currentStamina;

            // If the player has lost all it's stamina and the death flag hasn't been set yet...
            if (currentStamina <= 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
        }
        else
        {
            if (currentStamina < startingStamina)
            {
                currentStamina += Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -5f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 5f, 0);
        }
    }
}





