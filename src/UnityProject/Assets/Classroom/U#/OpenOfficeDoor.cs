
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class OpenOfficeDoor : UdonSharpBehaviour
{
    public GameObject O2CPortal; //Office hour to Classroom portal
    public GameObject InConversation; 

    
    public override void Interact()
    {
        O2CPortal.SetActive(true);
        InConversation.SetActive(false);
    }
}
