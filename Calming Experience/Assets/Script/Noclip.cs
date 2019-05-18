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
        if (Input.GetKeyUp(KeyCode.N))
        {
            noclip.enabled = false; //enable the script when space is pressed
        }
        else if (Input.GetKeyUp(KeyCode.M))
        {
            noclip.enabled = true; //disable the script when escape is pressed
        }
    }
}
