using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool buttonOn;
    // Start is called before the first frame update
    void Start()
    {
        buttonOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c)
    {
        buttonOn = c.GetComponent<PlayerMovement>() != null ? !buttonOn : buttonOn;
    }

    public void setButtonOn(bool state)
    {
        buttonOn = state;
    }

    public bool getButtonOn()
    {
        return buttonOn;
    }
}
