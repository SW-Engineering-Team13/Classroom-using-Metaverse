using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;

public class bookreturn : UdonSharpBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {

        string book = transform.parent.name;
        RawImage b = GameObject.Find("/Library/bookshelves/BorrowingBlock/Canvas/Menu/My/" + book).GetComponent<RawImage>();
        string which = "NonFiction";
        if(book == "fiction1"|| book == "fiction2" || book == "fiction3" || book == "fiction4")
        {
            which = "Fiction";
        }
        Debug.Log(which);
        b.gameObject.SetActive(false);
        Text cnt = GameObject.Find("/Library/bookshelves/BorrowingBlock/Canvas/Menu/" + which + "/" + book + "/Text").GetComponent<Text>();
        if (cnt.text == "0")
        {
            cnt.text = "1";
        }
        else if (cnt.text == "2")
        {
            cnt.text = "3";
        }
        else if (cnt.text == "1")
        {
            cnt.text = "2";
        }
    }

}
