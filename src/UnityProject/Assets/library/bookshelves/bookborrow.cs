using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;

public class bookborrow : UdonSharpBehaviour
{

    public Text count;
    

    void Start()
    {
        
    }

    public void OnClick()
    {
        string cnt = count.text;
        string book = transform.parent.name;
        RawImage b = GameObject.Find("/BorrowingBlock/Canvas/Menu/My/" + book).GetComponent<RawImage>();

        if (b.gameObject.activeSelf == false)
        {
            if (cnt == "3")
            {
                count.text = "2";
                //string book = transform.parent.name;
                //RawImage b = GameObject.Find("/BorrowingBlock/Canvas/Menu/My/"+book).GetComponent<RawImage>();
                b.gameObject.SetActive(true);
            }
            else if (cnt == "2")
            {
                count.text = "1";
                //string book = transform.parent.name;
                //RawImage b = GameObject.Find("/BorrowingBlock/Canvas/Menu/My/" + book).GetComponent<RawImage>();
                b.gameObject.SetActive(true);
            }
            else if (cnt == "1")
            {
                count.text = "0";
                //string book = transform.parent.name;
                //RawImage b = GameObject.Find("/BorrowingBlock/Canvas/Menu/My/" + book).GetComponent<RawImage>();
                b.gameObject.SetActive(true);
            }
        }

        
    }
}
