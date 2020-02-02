using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Thruster thruster;
    private bool buttonOn = false;

    void OnTriggerEnter(Collider c)
    {
        if (c.GetComponent<PlayerMovement>())
        {
            buttonOn = !buttonOn;
            thruster.OnButtonPress(buttonOn);
        }
    }
}
