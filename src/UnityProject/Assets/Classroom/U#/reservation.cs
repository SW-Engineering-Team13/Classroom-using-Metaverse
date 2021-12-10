
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;


public class reservation : UdonSharpBehaviour
{
    public GameObject NameField; //예약용
    public GameObject IDField; //예약용
    public GameObject SaveText; // student id 저장용
    public GameObject Self; //button 자신
    
    

    
    public override void Interact()
    {
        string name, id;
        //이미 예약된 경우는 버튼이 빨간색
        if(Self.GetComponent<Image>().color==Color.red){
            return;
        }
        
        // 이름과 아이디 얻기
        name=NameField.GetComponent<Text>().text;
        id=IDField.GetComponent<Text>().text;
        
        // 저장
        SaveText.GetComponent<Text>().text=id;

        //색깔 변경
        Self.GetComponent<Image>().color=Color.red;
    }    
}

