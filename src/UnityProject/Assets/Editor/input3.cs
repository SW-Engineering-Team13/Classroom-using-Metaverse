//from input1.cs
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class input3 : UdonSharpBehaviour
{
    public InputField InputField1; 
    // Checks if there is anything entered into the input field. 
    void LockInput(InputField input) { 
        if (input.text.Length > 0) { 
            Debug.Log("Text has been entered"); 
            } 
        else if (input.text.Length == 0) { Debug.Log("Main Input Empty"); } }

    // Start is called before the first frame update
    void Start()
    {
        //Use onEndEdit 
        InputField.onEndEdit.AddListener(delegate{LockInput(mainInputField1);});
        
        //Use onSubmit 
        mainInputField.onSubmit.AddListener(delegate{LockInput(mainInputField1);});

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
