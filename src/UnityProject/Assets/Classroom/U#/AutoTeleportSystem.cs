
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System;


public class AutoTeleportSystem : UdonSharpBehaviour
{
    public ClassroomData classroomData;
    public GameObject[] gameObjectsArr;
    public GameObject target;

    Boolean flag = true; //update tickrate controll
    int flagminute = -1;

    private void FixedUpdate()
    {
        /* every 20ms in VRChat */
        int minute = DateTime.Now.Minute;
        int hour = DateTime.Now.Hour;
  
        
        if (hour == classroomData.classStartTime.AddMinutes(-5).Hour && minute == classroomData.classStartTime.AddMinutes(-5).Minute && flag)
        {
            teleport();
        }
        flag = false;

        if (flagminute != minute)
        {
            /* 매 분 바뀔때마다 */
            flagminute = DateTime.Now.Minute;
            flag = true;
        }
        
    }

    public void teleport(){
        float x1 = gameObjectsArr[0].transform.position.x;
        float x2 = gameObjectsArr[0].transform.position.x;

        float z1 = gameObjectsArr[0].transform.position.z;
        float z2 = gameObjectsArr[0].transform.position.z;

        Vector3 pos = Networking.LocalPlayer.GetPosition();

        /* 이미 강의실 안 */
        if (pos.x > x1 && pos.x < x2 && pos.z > - z2 && pos.z < z1){
            return;
        }else{
            Debug.Log("Teleported!");
            
            Networking.LocalPlayer.TeleportTo(new Vector3( target.transform.position.x, target.transform.position.y, target.transform.position.z), new Quaternion(0, 0, 0, 0));
        }
        
        
        
    }
}
