
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class StudentData : UdonSharpBehaviour
{
     public int[] studentid;
    public string[] nickname;
    public string[] name;
    public string[] enroledclass;
    private void Start()
    {
        studentid = new int[1];
        nickname = new string[1];
        name = new string[1];
        enroledclass = new string[1];
        
        studentid[0] = 2014310199;
        nickname[0] = "nickname";
        name[0] = "Kangmin Lee";
        enroledclass[0] = "SWE3002_41";
    }
}
