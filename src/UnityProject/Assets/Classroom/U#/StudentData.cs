
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
    public void initialize()
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

    public int getIdByNickname(string nickname){
        int len = studentid.Length;
        for(int i = 0; i < len; i++){
            if(this.nickname[i].Equals(nickname)){
                return studentid[i];
            }

        }

        return -1;

    }

    public string getNameById(int id){
        int len = studentid.Length;
        for(int i = 0; i < len; i++){
            if(studentid[i] == id){
                return name[i];
            }

        }

        return "ERROR";
    }


    
}
