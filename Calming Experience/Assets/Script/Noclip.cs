using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noclip : MonoBehaviour
{
    LevelCamera noclip;
    // Start is called before the first frame update
    void Start()
    {
        noclip = gameObject.GetComponent<LevelCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float z = transform.position.z;
        float y = 1;
        if (Input.GetKeyUp(KeyCode.N))
        {
            noclip.enabled = false; //enable the script when space is pressed
        }
        else if (Input.GetKeyUp(KeyCode.M))
        {
            noclip.enabled = true; //disable the script when escape is pressed
        }

        if (noclip.enabled == false)
        {
            if(transform.position.y <= 0)
            {
                transform.position = new Vector3(x, y, z);
            }
        }
    }
}
