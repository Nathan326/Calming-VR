using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{
    LevelCamera flying;
    float speed;
    float sprintSpeed;
    public Rigidbody rb;

    void Start()
    {
        flying = gameObject.GetComponent<LevelCamera>();
        speed = 5f;
        sprintSpeed = 10f;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D))) //if the right arrow or D is pressed
        {
            rb.isKinematic = false; //the camera becomes non kinematic (means it collides)
            transform.position = transform.position + Camera.main.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            rb.isKinematic = false; //the camera becomes non kinematic (means it collides)
            transform.position = transform.position + Camera.main.transform.right * -speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
        {
            rb.isKinematic = false; //the camera becomes non kinematic (means it collides)
            transform.position = transform.position + Camera.main.transform.forward * -speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {
            rb.isKinematic = false; //the camera becomes non kinematic (means it collides)
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }

        if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.LeftArrow) &&
            !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.W)) 
        {
            rb.isKinematic = true; //the camera becomes kinematic (to stop it sliding)
            transform.position = transform.position;
        }

        if (flying.enabled == false)
        {
            sprintSpeed = 50f;
        }

        if (flying.enabled == true)
        {
            sprintSpeed = 10f;
        }

        if (Input.GetKey(KeyCode.LeftShift))

        {
            speed = sprintSpeed;
        }

        else
        {
            speed = speed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }


    }

}