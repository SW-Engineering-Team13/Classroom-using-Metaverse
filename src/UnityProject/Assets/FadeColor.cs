using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeColor : MonoBehaviour
{
    SpriteRenderer sr;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        sr = go.GetComponent<SpritRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(input.GetKeyDown("r"))
            sr.material.color = Color.red;
        if(input.GetKeyDown("g"))
            sr.material.color = Color.green;
        if(input.GetKeyDown("b"))
            sr.material.color = Color.blue;   
        if(input.GetKeyDown("m"))
            sr.material.color = Color.magenta;
        if(input.GetKeyDown("y"))
            sr.material.color = Color.yellow;
        if(input.GetKeyDown("c"))
            sr.material.color = Color.cyan;
        if(input.GetKeyDown("k"))
            sr.material.color = Color.black;   
        if(input.GetKeyDown("e"))
            sr.material.color = Color.gray;                   
    }
}
