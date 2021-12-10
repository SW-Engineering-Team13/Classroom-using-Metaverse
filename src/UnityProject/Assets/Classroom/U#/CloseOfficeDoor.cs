
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class CloseOfficeDoor : UdonSharpBehaviour
{
    public GameObject C2OPortal; //Classroom to Office hour portal
    public GameObject Door; //Door in office hour
    public GameObject InConversation; 

    
    public override void Interact()
    {
        C2OPortal.SetActive(false);
        Door.SetActive(false);
        InConversation.SetActive(true);
    }
}
