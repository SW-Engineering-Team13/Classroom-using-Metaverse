
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System.Collections;
using System.Collections.Generic;

public class DeskCameraChange : UdonSharpBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    
    private void Start() {
        cam1.SetActive(true);
    }

    void camswitch()
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

    void OnPlayerTriggerStay(VRCPlayerApi player) {
        camswitch();
    }



    

}