//from QnA2.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        var input = gameObject.GetComponent<InputField>();
        var se= new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit = se;
        */
        //or simply use the line below, 
        //input.onEndEdit.AddListener(SubmitName);  // This also works 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
