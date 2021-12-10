
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class CancelReservation : UdonSharpBehaviour
{
    public GameObject SaveText;
    public GameObject NameField;
    public GameObject IDField;
    public GameObject TimeButton; //시간 버튼
    
    public override void Interact()
    {
        string id, save;
        id=IDField.GetComponent<Text>().text;
        save=SaveText.GetComponent<Text>().text;
                
        //예약자의 학번과 입력한 학번이 다른 경우, 종료.
        if(id!=save){
            return;
        }

        //색깔 변경
        TimeButton.GetComponent<Image>().color=Color.white;
        //SaveText 내용 1234로 변경 (Default 값 : 1234)
        SaveText.GetComponent<Text>().text="1234";
    }
}
