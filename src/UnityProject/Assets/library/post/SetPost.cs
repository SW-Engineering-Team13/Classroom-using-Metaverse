using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;


public class SetPost : UdonSharpBehaviour
{
    public RawImage poster;
    public InputField inputField;
    public Button m_bt;
    public RawImage poster1;
    public RawImage poster2;
    public RawImage poster3;
    public RawImage poster4;
    public GameObject showposter;

    // Start is called before the first frame update
    void Start()
    {
        poster1.gameObject.SetActive(false);
        poster2.gameObject.SetActive(false);
        poster3.gameObject.SetActive(false);
        poster4.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        showposter = null;
        string which = inputField.text;
        string where = "/post/Prefabs/SceneDescriptionBlock/Canvas/Panel/Poster";
        string name = inputField.name;
        if(name == "pathInputField1")
        {
            where = where + "1/";
        }
        else if(name == "pathInputField2")
        {
            where = where + "2/";
        }
        else if(name == "pathInputField3")
        {
            where = where + "3/";
        }
        else if(name == "pathInputField4")
        {
            where = where + "4/";
        }
        
        Debug.Log(where);
//        showposter = GameObject.Find("Prefabs");
        showposter = GameObject.Find(where+which);
        

        if (showposter != null)
        {
            poster1.gameObject.SetActive(false);
            poster2.gameObject.SetActive(false);
            poster3.gameObject.SetActive(false);
            poster4.gameObject.SetActive(false);
            poster = showposter.GetComponent<RawImage>();
            poster.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("cannot find poster");
        }


    }
}
