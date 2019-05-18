using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.position = transform.position + Camera.main.transform.right * 5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.position = transform.position + Camera.main.transform.right * -5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
        {
            transform.position = transform.position + Camera.main.transform.forward * -5 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {
            transform.position = transform.position + Camera.main.transform.forward * 5 * Time.deltaTime;
        }

    }
}