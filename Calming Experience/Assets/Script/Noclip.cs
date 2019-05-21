using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noclip : MonoBehaviour
{
    LevelCamera noclip;
    // Start is called before the first frame update
    void Start()
    {
        noclip = gameObject.GetComponent<LevelCamera>(); //sets the variable noclip to mean the entire 'Level Camera' script
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x; //sets the variable x to where the camera is right now on the x axis
        float z = transform.position.z; //sets the variable z to where the camera is right now on the z axis
        float y = 2; //sets the variable y to the numeral 2

        if (Input.GetKeyUp(KeyCode.N)) //if the N button is pressed
        {
            noclip.enabled = false; //deactivates the 'Level Camera' script
        }
        else if (Input.GetKeyUp(KeyCode.M)) //if the M button is pressed
        {
            noclip.enabled = true; //reactivates the 'Level Camera' script
        }

        if (noclip.enabled == false) //if 'Level Camera' has been deactivated
        {
            if(transform.position.y <= 0) //if the camera's position is under 0 on the y axis
            {
                transform.position = new Vector3(x, y, z); //moves the camera, by keeping its x axis and z axis the same, but sends the camera to 2 on the y axis
            }
        }
    }
}
