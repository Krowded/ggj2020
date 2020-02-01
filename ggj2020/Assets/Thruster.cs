using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    public Rigidbody rb;
    public KeyCode togglekey;
    Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(togglekey))
        {
            rb.AddForceAtPosition(t.forward * Time.deltaTime * 100, t.position);
        }
    }
}
