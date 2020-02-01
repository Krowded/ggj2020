using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairInteractor : MonoBehaviour
{
    public RepairMeter repairMeter;
    [Range(0,1)]
    public float destructionSpeed;
    [Range(0,1)]
    public float repairSpeed;
    private int playersInBox = 0;

    void Update()
    {
        if (playersInBox > 0)
        {
            repairMeter.brokenness = Mathf.Max(repairMeter.brokenness - repairSpeed * Time.deltaTime, 0.0f);
        }
        else
        {
            repairMeter.brokenness = Mathf.Min(repairMeter.brokenness + destructionSpeed * Time.deltaTime, 1.0f);
        }
    }

    void OnTriggerEnter(Collider collider)  
    {
        if (collider.gameObject.GetComponent<PlayerMovement>())
        {
            ++playersInBox;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.GetComponent<PlayerMovement>())
        {
            --playersInBox;
        }
    }
}
