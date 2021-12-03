using System.Collections;
using System.Collections.Generic;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;


public class camswitch : UdonSharpBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    void Update()
    {
        if(Input.GetKey("1")){
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else if(Input.GetKey("2")){
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
