
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System.Collections.Generic;

public class AttendanceCheck : UdonSharpBehaviour
{
    StudentData[] studentDatas;
    ClassroomData[] classroomDatas;

    private void Start() {
        StudentData[] studentDatas = new StudentData[100];
        int[] enroledclass = new int[2];
        studentDatas[0].setData(000000, "nickname", "name", 1111); 
        studentDatas[1].setData(000001, "nickname", "name", 1112);
    }
    public override void OnPlayerTriggerEnter(VRCPlayerApi player) {
        Debug.Log(player.displayName);

        int len = studentDatas.Length;
        for(int i =0; i < len; i++){
            if(player.displayName.Equals(studentDatas[i].nickname)){
                //do  attendance check
            }

        }
        //player.displayName -> get student id 구현필요

        /*if(checkid()){

        }
        */
    }
}
public class ClassroomData{
    int classid;
    int[] studentidArr;

    public void setData(){
        
    }
}
public class StudentData
{
    public int studentid;
    public string nickname;
    public string name;
    public int enroledclass;

    public void setData(int id, string nickname, string name, int enroledclass ){
        studentid = id;
        this.nickname = nickname;
        this.name = name;
        this.enroledclass = enroledclass;
    }
}
