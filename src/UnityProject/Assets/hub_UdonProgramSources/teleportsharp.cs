
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class teleportsharp : UdonSharpBehaviour
{
    public Transform target;

    public override void Interact()
    {
        Networking.LocalPlayer.TeleportTo(target.position, target.rotation);
    }
}
