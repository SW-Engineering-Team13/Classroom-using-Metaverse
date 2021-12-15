using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;


public class PreviousButton : UdonSharpBehaviour
{

    public RawImage book1;
    public RawImage book2;
    public RawImage book3;
    public RawImage book4;
    
    public RawImage[] pages;

    //public GameObject showposter;

    // Start is called before the first frame update
    void Start()
    {
        /*book1.gameObject.SetActive(false);
        book2.gameObject.SetActive(false);
        book3.gameObject.SetActive(false);
        book4.gameObject.SetActive(false);*/
    }

    public void OnClick()
    {
        //GameObject text = transform.Find("Text").gameObject;
        Debug.Log(transform.parent.name);
        Debug.Log(transform.parent.name[transform.parent.name.Length-1]);
        int now = -1;
        pages = new RawImage[18];
        //Debug.Log(nowpages.Length);
        //Debug.Log(nowpages[0].name, nowpages[1].name);
        Debug.Log(pages.GetType());
        for(int i = 1; i < 19; i+=2)
        {
            Debug.Log("/bookshelves/ReadingBlock/Canvas/" + transform.parent.name + "/page" + i.ToString());
            pages[i-1] = GameObject.Find("/bookshelves/ReadingBlock/Canvas/" + transform.parent.name+"/page"+i.ToString()).GetComponent<RawImage>();
            pages[i] = GameObject.Find("/bookshelves/ReadingBlock/Canvas/" + transform.parent.name + "/page" + (i+1).ToString()).GetComponent<RawImage>();
            if (pages[i-1].gameObject.activeSelf == true)
            {
                now = i - 1;
                break;
            }
        }

        
        if(now == -1)
        {
            pages[16].gameObject.SetActive(false);
            pages[17].gameObject.SetActive(false);
        }
        if (now >= 2)
        {
            pages[now].gameObject.SetActive(false);
            pages[now + 1].gameObject.SetActive(false);
            pages[now-2].gameObject.SetActive(true);
            pages[now - 1].gameObject.SetActive(true);
        }


    }
}
