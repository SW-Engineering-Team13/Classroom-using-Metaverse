
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class CheckReservation : UdonSharpBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject IDField;
    public GameObject C2OPortal; //Classroom to Office hour portal
    public GameObject Door; //Door in office hour
    public GameObject O2CPortal; //Office hour to Classroom portal

    
    public override void Interact()
    {
        string id=IDField.GetComponent<Text>().text;
        
        //예약 정보와 일치하는 경우 혹은 교수님인 경우 (교수님의 비밀번호: 0000)
        if(id==Text1.GetComponent<Text>().text || id==Text2.GetComponent<Text>().text || id==Text3.GetComponent<Text>().text || id=="0000"){
            C2OPortal.SetActive(true);
            Door.SetActive(true);
            O2CPortal.SetActive(false);
        }
    }
}


