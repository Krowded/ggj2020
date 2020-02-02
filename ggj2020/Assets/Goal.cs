using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<PlayerMovement>())
        {
            Application.Quit();
        }
    }
}
