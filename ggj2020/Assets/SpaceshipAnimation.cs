using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipAnimation : MonoBehaviour
{
    struct CornerTruster
    {
        Vector3 pos;
        Vector3 dirU;
        Vector3 dirV;
        bool toggleU;
        bool toggleV;
    };

    Rigidbody rb;
    Transform t;
    CornerTruster[] thursters = { 
        new CornerTruster(),
        new CornerTruster(),
        new CornerTruster(),
        new CornerTruster(),
    };
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForceAtPosition();
    }
}
