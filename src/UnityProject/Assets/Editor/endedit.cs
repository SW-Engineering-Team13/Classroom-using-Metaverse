using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://geukggom.tistory.com/143
public InputField myInputField;
public class endedit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        myInputField.onEndEdit.AddListener(ValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(text + "를 입력함");
    }
}
