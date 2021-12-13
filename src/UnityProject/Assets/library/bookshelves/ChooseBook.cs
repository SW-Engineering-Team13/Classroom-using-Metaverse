using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.Udon;
using System;


public class ChooseBook : UdonSharpBehaviour
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
        book1.gameObject.SetActive(true);
        book2.gameObject.SetActive(true);
        book3.gameObject.SetActive(true);
        book4.gameObject.SetActive(true);
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(false);
        panel3.gameObject.SetActive(false);
        panel4.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        //GameObject text = transform.Find("Text").gameObject;
        Debug.Log(transform.name);
        RawImage page1;
        RawImage page2;
        RawImage page3;
        RawImage page4;
        RawImage page5;
        RawImage page6;
        RawImage page7;
        RawImage page8;
        RawImage page9;
        RawImage page10;
        RawImage page11;
        RawImage page12;
        RawImage page13;
        RawImage page14;
        RawImage page15;
        RawImage page16;
        RawImage page17;
        RawImage page18;
        if(transform.name == "Button1")
        {
            panel1.gameObject.SetActive(true);
            page1 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page1").GetComponent<RawImage>();
            page2 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page2").GetComponent<RawImage>();
            page3 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page3").GetComponent<RawImage>();
            page4 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page4").GetComponent<RawImage>();
            page5 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page5").GetComponent<RawImage>();
            page6 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page6").GetComponent<RawImage>();
            page7 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page7").GetComponent<RawImage>();
            page8 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page8").GetComponent<RawImage>();
            page9 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page9").GetComponent<RawImage>();
            page10 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page10").GetComponent<RawImage>();
            page11 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page11").GetComponent<RawImage>();
            page12 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page12").GetComponent<RawImage>();
            page13 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page13").GetComponent<RawImage>();
            page14 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page14").GetComponent<RawImage>();
            page15 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page15").GetComponent<RawImage>();
            page16 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page16").GetComponent<RawImage>();
            page17 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page17").GetComponent<RawImage>();
            page18 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel1/page18").GetComponent<RawImage>();

            page1.gameObject.SetActive(true);
            page2.gameObject.SetActive(true);
            page3.gameObject.SetActive(false);
            page4.gameObject.SetActive(false);
            page5.gameObject.SetActive(false);
            page6.gameObject.SetActive(false);
            page7.gameObject.SetActive(false);
            page8.gameObject.SetActive(false);
            page9.gameObject.SetActive(false);
            page10.gameObject.SetActive(false);
            page11.gameObject.SetActive(false);
            page12.gameObject.SetActive(false);
            page13.gameObject.SetActive(false);
            page14.gameObject.SetActive(false);
            page15.gameObject.SetActive(false);
            page16.gameObject.SetActive(false);
            page17.gameObject.SetActive(false);
            page18.gameObject.SetActive(false);
        
        }
        else if (transform.name == "Button2")
        {
            panel2.gameObject.SetActive(true);
            page1 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page1").GetComponent<RawImage>();
            page2 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page2").GetComponent<RawImage>();
            page3 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page3").GetComponent<RawImage>();
            page4 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page4").GetComponent<RawImage>();
            page5 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page5").GetComponent<RawImage>();
            page6 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page6").GetComponent<RawImage>();
            page7 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page7").GetComponent<RawImage>();
            page8 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page8").GetComponent<RawImage>();
            page9 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page9").GetComponent<RawImage>();
            page10 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page10").GetComponent<RawImage>();
            page11 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page11").GetComponent<RawImage>();
            page12 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page12").GetComponent<RawImage>();
            page13 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page13").GetComponent<RawImage>();
            page14 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page14").GetComponent<RawImage>();
            page15 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page15").GetComponent<RawImage>();
            page16 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page16").GetComponent<RawImage>();
            page17 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page17").GetComponent<RawImage>();
            page18 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel2/page18").GetComponent<RawImage>();

            page1.gameObject.SetActive(true);
            page2.gameObject.SetActive(true);
            page3.gameObject.SetActive(false);
            page4.gameObject.SetActive(false);
            page5.gameObject.SetActive(false);
            page6.gameObject.SetActive(false);
            page7.gameObject.SetActive(false);
            page8.gameObject.SetActive(false);
            page9.gameObject.SetActive(false);
            page10.gameObject.SetActive(false);
            page11.gameObject.SetActive(false);
            page12.gameObject.SetActive(false);
            page13.gameObject.SetActive(false);
            page14.gameObject.SetActive(false);
            page15.gameObject.SetActive(false);
            page16.gameObject.SetActive(false);
            page17.gameObject.SetActive(false);
            page18.gameObject.SetActive(false);


        }
        else if (transform.name == "Button3")
        {
            panel3.gameObject.SetActive(true);
            page1 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page1").GetComponent<RawImage>();
            page2 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page2").GetComponent<RawImage>();
            page3 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page3").GetComponent<RawImage>();
            page4 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page4").GetComponent<RawImage>();
            page5 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page5").GetComponent<RawImage>();
            page6 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page6").GetComponent<RawImage>();
            page7 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page7").GetComponent<RawImage>();
            page8 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page8").GetComponent<RawImage>();
            page9 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page9").GetComponent<RawImage>();
            page10 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page10").GetComponent<RawImage>();
            page11 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page11").GetComponent<RawImage>();
            page12 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page12").GetComponent<RawImage>();
            page13 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page13").GetComponent<RawImage>();
            page14 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page14").GetComponent<RawImage>();
            page15 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page15").GetComponent<RawImage>();
            page16 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page16").GetComponent<RawImage>();
            page17 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page17").GetComponent<RawImage>();
            page18 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel3/page18").GetComponent<RawImage>();

            page1.gameObject.SetActive(true);
            page2.gameObject.SetActive(true);
            page3.gameObject.SetActive(false);
            page4.gameObject.SetActive(false);
            page5.gameObject.SetActive(false);
            page6.gameObject.SetActive(false);
            page7.gameObject.SetActive(false);
            page8.gameObject.SetActive(false);
            page9.gameObject.SetActive(false);
            page10.gameObject.SetActive(false);
            page11.gameObject.SetActive(false);
            page12.gameObject.SetActive(false);
            page13.gameObject.SetActive(false);
            page14.gameObject.SetActive(false);
            page15.gameObject.SetActive(false);
            page16.gameObject.SetActive(false);
            page17.gameObject.SetActive(false);
            page18.gameObject.SetActive(false);


        }
        else if (transform.name == "Button4")
        {
            panel4.gameObject.SetActive(true);
            page1 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page1").GetComponent<RawImage>();
            page2 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page2").GetComponent<RawImage>();
            page3 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page3").GetComponent<RawImage>();
            page4 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page4").GetComponent<RawImage>();
            page5 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page5").GetComponent<RawImage>();
            page6 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page6").GetComponent<RawImage>();
            page7 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page7").GetComponent<RawImage>();
            page8 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page8").GetComponent<RawImage>();
            page9 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page9").GetComponent<RawImage>();
            page10 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page10").GetComponent<RawImage>();
            page11 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page11").GetComponent<RawImage>();
            page12 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page12").GetComponent<RawImage>();
            page13 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page13").GetComponent<RawImage>();
            page14 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page14").GetComponent<RawImage>();
            page15 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page15").GetComponent<RawImage>();
            page16 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page16").GetComponent<RawImage>();
            page17 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page17").GetComponent<RawImage>();
            page18 = GameObject.Find("/bookshelves/ReadingBlock/Canvas/Panel4/page18").GetComponent<RawImage>();

            page1.gameObject.SetActive(true);
            page2.gameObject.SetActive(true);
            page3.gameObject.SetActive(false);
            page4.gameObject.SetActive(false);
            page5.gameObject.SetActive(false);
            page6.gameObject.SetActive(false);
            page7.gameObject.SetActive(false);
            page8.gameObject.SetActive(false);
            page9.gameObject.SetActive(false);
            page10.gameObject.SetActive(false);
            page11.gameObject.SetActive(false);
            page12.gameObject.SetActive(false);
            page13.gameObject.SetActive(false);
            page14.gameObject.SetActive(false);
            page15.gameObject.SetActive(false);
            page16.gameObject.SetActive(false);
            page17.gameObject.SetActive(false);
            page18.gameObject.SetActive(false);


        }


    }
}
