using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;


public class BackButton : UdonSharpBehaviour
{

    public RawImage book1;
    public RawImage book2;
    public RawImage book3;
    public RawImage book4;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;

    //public GameObject showposter;

    // Start is called before the first frame update
    void Start()
    {
        //panel1 = GameObject.Find("Panel1");
        //if (panel1 == null) Debug.Log("No Panel");
        book1.gameObject.SetActive(false);
        book2.gameObject.SetActive(false);
        book3.gameObject.SetActive(false);
        book4.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(false);
        panel3.gameObject.SetActive(false);
        panel4.gameObject.SetActive(false);
        book1.gameObject.SetActive(true);
        book2.gameObject.SetActive(true);
        book3.gameObject.SetActive(true);
        book4.gameObject.SetActive(true);


    }
}
