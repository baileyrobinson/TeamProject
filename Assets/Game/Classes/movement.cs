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
    public Rigidbody rb; 

    // Use this for initialization
    void Start()
    {
        currentStamina = startingStamina;
        rb.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float haxis = Input.GetAxis("Horizontal");
        float vaxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(haxis, 0, vaxis) * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);

        /*
        if (Input.GetKey("w"))
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

        if (currentStamina < startingStamina)
        {
            currentStamina += Time.deltaTime;
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
        */
    }
}




