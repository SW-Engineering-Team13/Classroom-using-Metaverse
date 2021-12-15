using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteKeyBoardCharactorController : MonoBehaviour {

    private KiteCharactorContollerHandler _handler = new KiteCharactorContollerHandler();
    
    void Awake()
    {
        _handler.CharactorInfo.CharactorObj = this.gameObject;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _handler.GoToLeft();
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _handler.GoToBack();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _handler.GoToRight();
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _handler.GoToForward();
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _handler.ChangeCrouchState();
        }

        if (Input.GetMouseButton(0))
        {
            _handler.SetHorizontalOffset(Input.GetAxis("Mouse X"));
        }

        if(Input.GetMouseButton(1))
        {
            _handler.SetVerticalOffset(Input.GetAxis("Mouse Y"));
        }

        _handler.Update();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        PhysicsEventManager.Instance.InvokeEvent(PhysicsEventManager.HandlerType.Role, PhysicsEventType.TriggerEnter
            , new PhysiscsEventArgs() { TriggerCollider = other, RigidbodyObject = this.gameObject });
    }

    private void OnTriggerExit(Collider other)
    {
        PhysicsEventManager.Instance.InvokeEvent(PhysicsEventManager.HandlerType.Role, PhysicsEventType.TriggerExit
            , new PhysiscsEventArgs() { TriggerCollider = other, RigidbodyObject = this.gameObject });
    }
}
