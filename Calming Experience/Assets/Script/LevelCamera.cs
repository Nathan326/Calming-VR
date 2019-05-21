using UnityEngine;
using System.Collections;

public class LevelCamera : MonoBehaviour
{

    void Update()
    {
        float x = transform.position.x;
        float z = transform.position.z;
        float y = 2;
        transform.position = new Vector3(x, y, z);
    }
}
