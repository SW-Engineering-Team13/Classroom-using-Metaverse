﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;

public class nonfictionbtn : UdonSharpBehaviour
{
    public GameObject nonfiction;
    public GameObject fiction;
    public GameObject my;

    public void OnClick()
    {
        Debug.Log("fdsa");
        my.gameObject.SetActive(false);
        fiction.gameObject.SetActive(false);
        nonfiction.gameObject.SetActive(true);
        
    }
}
