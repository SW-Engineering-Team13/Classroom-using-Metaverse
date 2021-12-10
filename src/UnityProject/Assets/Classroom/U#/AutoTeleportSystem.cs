
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System;


public class AutoTeleportSystem : UdonSharpBehaviour
{
    public ClassroomData classroomData;

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
            Debug.Log("teleport");
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
        Vector3 pos = Networking.LocalPlayer.GetPosition();
        if (pos.x > -10 && pos.x < 10 && pos.z > - 15 && pos.z < 15){
            return;
        }else{
            Debug.Log("Teleported!");
            Networking.LocalPlayer.TeleportTo(new Vector3( (float)8.9, (float)0.75, (float)-12.4), new Quaternion(0, 0, 0, 0));
        }
        
        
        
    }
}
