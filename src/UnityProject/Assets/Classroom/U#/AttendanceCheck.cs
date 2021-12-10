
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System;
using UnityEngine.UI;

public class AttendanceCheck : UdonSharpBehaviour
{
    public ClassroomData classroomData;
    public StudentData studentData;

    public bool isLate = false; //지각 출석용

    public bool flag = true; //fixedupdate 과도한 업데이트 방지
    public GameObject panelList;

    private int flagminute = -1;
    public void activateCollider(bool isLate)
    {
        this.isLate = isLate;

        /* 강의 시작시 collider 활성화 */
        if (!isLate)
        {
            BoxCollider temp = (BoxCollider)this.gameObject.GetComponent(typeof(BoxCollider));
            temp.enabled = true;

            /* 지각 collider 활성화 */
        }
        else
        {
            BoxCollider temp = (BoxCollider)this.gameObject.GetComponent(typeof(BoxCollider));
            temp.enabled = true;
        }
    }


    private void FixedUpdate()
    {
        /* every 20ms in VRChat */
        int minute = DateTime.Now.Minute;
        int hour = DateTime.Now.Hour;
        if (hour == classroomData.classStartTime.Hour && minute == classroomData.classStartTime.Minute && flag)
        {
            activateCollider(false);
            Debug.Log("attendance checked(on time)");
        }
        else if (hour == classroomData.classStartTime.AddMinutes(10).Hour && minute == classroomData.classStartTime.AddMinutes(10).Minute && flag)
        {
            activateCollider(true);
            Debug.Log("attendance checked(late)");
        }else if ( hour == classroomData.classStartTime.AddMinutes(-10).Hour && minute == classroomData.classStartTime.AddMinutes(-10).Minute && flag ){
            resetPanel();
        }
        flag = false; //매 분마다 if 문 한번만 진입

        if (flagminute != minute)
        {
            /* 매 분 바뀔때마다 */
            flagminute = DateTime.Now.Minute;
            flag = true;
        }
    }
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {

        Debug.Log(player.displayName);

        int len = studentData.studentid.Length;
        /* 닉네임 기반으로 학번 체크 */
        for (int i = 0; i < len; i++)
        {
            /* 일치하는 학번 발견시 */
            if (studentData.nickname[i].Equals(player.displayName))
            {
                /* 강의실 정보에서 수강중인 학번 체크 */
                for (int j = 0; j < classroomData.studentidArr.Length; j++)
                {
                    /* 수강중인 학생 발견시 */
                    if (classroomData.studentidArr[j] == studentData.studentid[i])
                    {
                        /*지각출석*/
                        if (isLate)
                        {
                            GameObject gtemp = panelList.transform.GetChild(j).gameObject;
                            Image itemp = (Image)gtemp.GetComponentInChildren(typeof(Image));
                           
                            if(itemp.color == Color.red){
                                itemp.color = Color.yellow;
                            }

                            /*정상출석*/
                        }
                        else
                        {
                            GameObject gtemp = panelList.transform.GetChild(j).gameObject;
                            Image itemp = (Image)gtemp.GetComponentInChildren(typeof(Image));

                            if(itemp.color == Color.red){
                                itemp.color = Color.green;
                            }


                        }
                    }
                }
            }
        }
        //deactivate collider
        BoxCollider temp = (BoxCollider)this.gameObject.GetComponent(typeof(BoxCollider));
        temp.enabled = false;
    }

    public void resetPanel()
    {
        int len = classroomData.studentidArr.Length;

        for (int i = 0; i < len; i++)
        {
            GameObject gtemp = panelList.transform.GetChild(i).gameObject;
            Image itemp = (Image)gtemp.GetComponentInChildren(typeof(Image));
            itemp.color = Color.red;
        }


    }

}


