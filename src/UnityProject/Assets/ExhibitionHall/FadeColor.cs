using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeColor : MonoBehaviour
{
    public SpriteRenderer sr;
    //public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        //sr = go.GetComponent<SpritRenderer>();
        Debug.Log("start");
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")){
            Debug.Log("red");
            sr.material.color = Color.red;
        }
        if(Input.GetKeyDown("g")){
            Debug.Log("green");
            sr.material.color = Color.green;
        }    
        if(Input.GetKeyDown("b")){
            Debug.Log("b");
            sr.material.color = Color.blue;
        }       
        if(Input.GetKeyDown("m")){
            Debug.Log("m");
            sr.material.color = Color.magenta;
        }    
        if(Input.GetKeyDown("y")){
            Debug.Log("y");
            sr.material.color = Color.yellow;
        }    
        if(Input.GetKeyDown("c")){
            Debug.Log("c");
            sr.material.color = Color.cyan;
        }    
        if(Input.GetKeyDown("k")){
            sr.material.color = Color.black; 
        }
        if(Input.GetKeyDown("e")){
            sr.material.color = Color.gray;  
        }
        if(Input.GetKeyDown("u")){
            sr.material.color = Color.clear;  
        }                        
    }
}
