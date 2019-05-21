using UnityEngine;
using System.Collections;

public class LevelCamera : MonoBehaviour
{

    void Update()
    {
        float x = transform.position.x; //sets the variable x to where the camera is right now on the x axis
        float z = transform.position.z; //sets the variable z to where the camera is right now on the z axis
        float y = 2; //sets the variable y to the numeral 2
        transform.position = new Vector3(x, y, z); //moves the camera, by keeping its x axis and z axis the same, but sends the camera to 2 on the y axis
    }
}
