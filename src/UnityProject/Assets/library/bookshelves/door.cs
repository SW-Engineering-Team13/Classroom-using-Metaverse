using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;

public class door : UdonSharpBehaviour
{
    public GameObject gameobject;
    public int open = 1;

    void start()
    {
        Debug.Log("start");
    }
    void Interact()
    {
        Debug.Log("clicked");
        if (open == 1)
        {
            if (transform.name == "left")
            {
                gameobject.transform.localEulerAngles = new Vector3(0, 0, 0);
                Debug.Log("asdf");
            }
            else
            {
                gameobject.transform.localEulerAngles = new Vector3(0, 0, 0);
                Debug.Log("asdf");
            }

            open = 0;
        }
        else
        {
            if (transform.name == "right")
            {
                gameobject.transform.localEulerAngles = new Vector3(0, -90, 0);
                Debug.Log("asdf");
            }
            else
            {
                gameobject.transform.localEulerAngles = new Vector3(0, 90, 0);
                Debug.Log("asdf");
            }
            open = 1;
        }

    }

}
