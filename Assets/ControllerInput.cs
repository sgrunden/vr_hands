using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ControllerInput : MonoBehaviour
{
    // Update is called once per frame

    string _rightTriggerButtonInputName = "XRI_Right_TriggerButton";


    public Action rightTriggerButtonDown;


    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown(_rightTriggerButtonInputName))
        {
            if(rightTriggerButtonDown!=null)
                rightTriggerButtonDown.Invoke();

            Debug.Log("Trigger button down");
        }
    }


}
