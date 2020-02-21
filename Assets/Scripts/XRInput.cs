using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class XRInput : MonoBehaviour
{
    // These strings will serve as the triggerName parameter for the trigger-getting methods.
    private string triggerName;
    private string rightTriggerButton = "RightTriggerButton"; 
    private string leftTriggerButton = "LeftTriggerButton";

    private InputDevice hand;

    public HandGrabbing leftHand;
    public HandGrabbing rightHand;

    private void Start()
    {

    }

    void Update()
    {

    }

    #region Hand Controller Methods
    public InputDevice GetHands(InputDevice currentHand)
    {
        currentHand = InputDevices.GetDeviceAtXRNode(GetNodeType(currentHand));
        return currentHand;
    }
    
   /* XRNode GetNodeType(InputDevice currentHand)
    {
        XRNode nodeType;
        if (leftHand.tag == "LeftHand")
        {
            nodeType = XRNode.LeftHand;
        }
        if (rightHand.tag == "RightHand")
        {
            nodeType = XRNode.RightHand;
        }
        else
        {
            nodeType = XRNode.GameController;
        }
        return nodeType;
    }*/
    #endregion


    #region Button Methods
    bool GetTriggerDown() // Returns true the first frame that the trigger is pressed
    {
        bool triggerState;
        if(hand.TryGetFeatureValue(CommonUsages.triggerButton, out triggerState))
        {
            Debug.Log("You pressed the trigger button!");
            return true;
        }
        return false;
    }

    bool GetTriggerUp() // Returns true the first frame that the trigger is released
    {
        bool triggerState;
        if (!hand.TryGetFeatureValue(CommonUsages.triggerButton, out triggerState))
        {
            Debug.Log("You released the trigger button!");
            return true;
        }
        return false;
    }

    bool GetTriggerHeld() // Returns true while the trigger is being held down
    {
        bool triggerState;
        if (hand.TryGetFeatureValue(CommonUsages.triggerButton, out triggerState) && triggerState)
        {
            Debug.Log("You are holding the trigger button!");
            return true;
        }
        return false;
    }

    bool GetTrackpadDown() // Returns true the first frame that the trackpad button is pressed
    {
        bool trackpadState;
        if (hand.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out trackpadState))
        {
            Debug.Log("You pressed the trackpad button!");
            return true;
        }
        return false;
    }

    bool GetTrackpadUp() // Returns true the first frame the trackpad button is released
    {
        bool trackpadState;
        if (!hand.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out trackpadState))
        {
            Debug.Log("You released the trackpad button!");
            return true;
        }
        return false;
    }

    bool GetTrackpadHeld() // Returns true while the trackpad button is being held down
    {
        bool trackpadState;
        if (hand.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out trackpadState) && trackpadState)
        {
            Debug.Log("You are holding the trackpad button!");
            return true;
        }
        return false;
    }

    bool GetGripDown() // Returns true the first frame that the grip button is pressed
    {
        bool gripState;
        if (hand.TryGetFeatureValue(CommonUsages.gripButton, out gripState))
        {
            Debug.Log("You pressed the grip button!");
            return true;
        }
        return false;
    }

    bool GetGripUp() // Returns true the first frame that the grip button is released
    { 
        bool gripState;
        if (hand.TryGetFeatureValue(CommonUsages.gripButton, out gripState))
        {
            Debug.Log("You released the grip button!");
            return true;
        }
        return false;
    }

    bool GetGripHeld() // Returns true while the grip button is being held down
    {
        bool gripState;
        if (hand.TryGetFeatureValue(CommonUsages.gripButton, out gripState))
        {
            Debug.Log("You are holding the grip button!");
            return true;
        }
        return false;
    }
    #endregion
}
