using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveController : MonoBehaviour
{
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Input_Sources rightHand;
    public SteamVR_Input_Sources any;
    public SteamVR_Action_Boolean trigger;
    public SteamVR_Action_Boolean trackPadClick = SteamVR_Actions.default_Teleport;
    public SteamVR_Action_Boolean trackPadTouch = SteamVR_Actions.default_TrackPadTouch;
    public SteamVR_Action_Vector2 trackPadPosition = SteamVR_Actions.default_TrackPadPosition;

    private void Awake()
    {
        trigger = SteamVR_Actions.default_InteractUI;
    }
    void Update()
    {
        if(trigger.GetStateDown(leftHand))
        {
            Debug.Log("Clicked Trigger Button");
        }
        if(trigger.GetStateUp(rightHand))
        {
            Debug.Log("Released Trigger Button");
        }
        if(trackPadClick.GetStateDown(any))
        {
            Debug.Log("TrackPad Click");
        }
        if(trackPadTouch.GetState(any))
        {
            Vector2 pos = trackPadPosition.GetAxis(any);
            Debug.Log($"Touch Pos X={pos.x}/y={pos.y}");
        }
    }
}
