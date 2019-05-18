using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{
    LevelCamera flying;
    float speed;
    float sprintSpeed;

    void Start()
    {
        flying = gameObject.GetComponent<LevelCamera>();
        speed = 5f;
        sprintSpeed = 10f;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.position = transform.position + Camera.main.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.position = transform.position + Camera.main.transform.right * -speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
        {
            transform.position = transform.position + Camera.main.transform.forward * -speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
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