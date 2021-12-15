using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;

public class loginbutton : UdonSharpBehaviour
{

    public GameObject menu;
    public GameObject my;
    public GameObject fiction;
    public GameObject nonfiction;
    public InputField studentid;
    public InputField pw;

    public string[] Studentid;
    public string[] Nickname;
    public string[] Name;
    public string[] Password;

    // Start is called before the first frame update
    void Start()
    {

        Studentid = new string[1];
        Nickname = new string[1];
        Name = new string[1];
        Password = new string[1];

        Studentid[0] = "2018311882";
        Nickname[0] = "nickname";
        Name[0] = "Sohee Yoon";
        Password[0] = "pppp";

        menu.gameObject.SetActive(false);
        Debug.Log("asdfasdf");

    }

    // Update is called once per frame
    public void OnClick()
    {
        string Id = studentid.text;
        string PW = pw.text;

        Debug.Log(Id);
        Debug.Log(PW);

        //        int index = Array.FindIndex(Studentid, x => x == Id);
        int len = Studentid.Length;
        Debug.Log(len);
        Debug.Log(Studentid[0]);
        for(int i = 0; i < len; i++)
        {
            if(Id == Studentid[i])
            {
                if(PW == Password[i])
                {
                    menu.gameObject.SetActive(true);
                    my.gameObject.SetActive(false);
                    fiction.gameObject.SetActive(false);
                    nonfiction.gameObject.SetActive(false);
                }
                else
                {
                    Debug.Log("False Password");
                }
            }
        }

    }
}
