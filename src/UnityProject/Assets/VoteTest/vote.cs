
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]

public class vote : UdonSharpBehaviour
{
    [UdonSynced, FieldChangeCallback(nameof(SyncedNumber))] private int _syncedNumber = 0;
    public GameObject Vote;

    public int SyncedNumber
    {
        set
        {
            Debug.Log("toggling the object...");
            _syncedNumber = value;
            Vote.GetComponent<Text>().text = _syncedNumber.ToString();
        }
        get => _syncedNumber;
    }

    public override void Interact()
    {
        Networking.SetOwner(Networking.LocalPlayer, this.gameObject);
        SyncedNumber++;
        RequestSerialization();
    }
}
