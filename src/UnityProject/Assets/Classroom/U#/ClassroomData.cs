
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
    private void Start()
    {
        Debug.Log(DateTime.Now);
        classStartTime = new DateTime(0, 0, 0, 15, 0, 0);
        classEndTime = new DateTime(0, 0, 0, 17, 45, 0);
        
        studentidArr = new int[1];
        int i = 0;
        studentidArr[i] = 0000000000;

    }
}
