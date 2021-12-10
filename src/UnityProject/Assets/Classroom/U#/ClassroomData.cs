
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System;

public class ClassroomData : UdonSharpBehaviour
{

    public int classid;
    public int[] studentidArr;
    public DateTime classStartTime;
    public DateTime classEndTime;
    public int initialLize()
    {
        Debug.Log(DateTime.Now);
        classStartTime = new DateTime(1, 1, 1, 5, 30, 0);
        classEndTime = new DateTime(1, 1, 1, 17, 45, 0);
        
        studentidArr = new int[1];
        int i = 0;
        studentidArr[i] = 2014310199;
        return i;
    }
}
