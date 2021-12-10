
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class OpenCounselingDoor : UdonSharpBehaviour
{
    public GameObject C2SPortal; //Classroom to Couseling portal
    public GameObject Door; //Door in counseling
    public GameObject S2CPortal; //Couseling to Classroom portal
    public GameObject InConversation; 

    
    public override void Interact()
    {
        C2SPortal.SetActive(true);
        InConversation.SetActive(false);
        Door.SetActive(true);
        S2CPortal.SetActive(true);
    }
}
