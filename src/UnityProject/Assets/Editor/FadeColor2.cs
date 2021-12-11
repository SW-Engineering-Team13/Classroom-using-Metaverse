using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeColor2 : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        sr = go.GetComponent<SpritRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r"))
            sr.material.color = Color.red;
        if(Input.GetKeyDown("g"))
            sr.material.color = Color.green;
        if(Input.GetKeyDown("b"))
            sr.material.color = Color.blue;   
        if(Input.GetKeyDown("m"))
            sr.material.color = Color.magenta;
        if(Input.GetKeyDown("y"))
            sr.material.color = Color.yellow;
        if(Input.GetKeyDown("c"))
            sr.material.color = Color.cyan;
        if(Input.GetKeyDown("k"))
            sr.material.color = Color.black;   
        if(Input.GetKeyDown("e"))
            sr.material.color = Color.gray;                   
    }
}
