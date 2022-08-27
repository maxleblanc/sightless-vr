using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Uduino;

public class HapticTouch2 : MonoBehaviour
{
    public bool hapticflag = false;
    public SteamVR_Action_Vibration hapticAction;

    private void Start()
    {
        UduinoManager.Instance.pinMode(7, PinMode.Output);
    }
    void Update()
    {
            if(hapticflag)
        {
            Pulse(0.1f, 100, 75, SteamVR_Input_Sources.Any);
            UduinoManager.Instance.digitalWrite(7, State.HIGH);
        }
    }
    void OnTriggerEnter()
    {
        hapticflag = true;
    }
    void OnTriggerExit()
    {
        hapticflag = false;
        UduinoManager.Instance.digitalWrite(7, State.LOW);
    }
    private void Pulse(float duration, float frequency, float amplitude, SteamVR_Input_Sources source)
    {
        hapticAction.Execute(0, duration, frequency, amplitude, source);
        print("Pulse");
    }
}

