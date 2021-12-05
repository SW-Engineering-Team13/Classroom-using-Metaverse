
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System;

public class AttendanceCheck : UdonSharpBehaviour
{
    public ClassroomData classroomData;
    public StudentData studentData;

    public bool isLate = false; //지각 출석용

    public bool flag = true; //fixedupdate 과도한 업데이트 방지

    private int flagminute = 0;
    public void activateCollider(bool isLate){
        this.isLate = isLate;
        
        /* 강의 시작시 collider 활성화 */
        if(!isLate){
            BoxCollider temp = (BoxCollider) this.gameObject.GetComponent(typeof(BoxCollider));
            temp.enabled = true;

        /* 지각 collider 활성화 */
        }else{
            BoxCollider temp = (BoxCollider) this.gameObject.GetComponent(typeof(BoxCollider));
            temp.enabled = true;
        }
    }
    

    private void FixedUpdate() {
        /* every 20ms in VRChat */
        int minute = DateTime.Now.Minute;
        int hour = DateTime.Now.Hour;
        if(hour == classroomData.classStartTime.Hour && minute == classroomData.classStartTime.Minute && flag){
            flag = false; //0.02초마다 반복되는것 방지용
            activateCollider(false);
        }else if(hour == classroomData.classStartTime.AddMinutes(10).Hour && minute == classroomData.classStartTime.AddMinutes(10).Minute && flag){
            flag = false;
            activateCollider(true);
        }

        if(flagminute != DateTime.Now.Minute){
            /* 매 분 바뀔때마다 */
            flagminute = DateTime.Now.Minute;
            flag = true;
        }
    }
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        if(!player.isLocal)
            return;
            
        Debug.Log(player.displayName);
    
            int len = studentData.studentid.Length;
            /* 닉네임 기반으로 학번 체크 */
            for(int i = 0; i < len; i++){
                /* 일치하는 학번 발견시 */
                if(studentData.nickname[i].Equals(player.displayName)){
                    /* 강의실 정보에서 수강중인 학번 체크 */
                    for(int j = 0; j < classroomData.studentidArr.Length; j++){
                        /* 수강중인 학생 발견시 */
                        if(classroomData.studentidArr[j] == studentData.studentid[i]){
                            /*지각출석*/
                            if(isLate){
                                //출석패널 연동필요
                                BoxCollider temp = (BoxCollider) this.gameObject.GetComponent(typeof(BoxCollider));
                                temp.enabled = false;
                            /*정상출석*/
                            }else{
                                //출석패널 연동필요
                                BoxCollider temp = (BoxCollider) this.gameObject.GetComponent(typeof(BoxCollider));
                                temp.enabled = false;
                            }
                        }
                    }
                }
            }

        //deactivate collider
    }

}
 

