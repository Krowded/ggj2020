using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{
    public float ts_x, ts_y, ts_z;
    //public float spinSpeed = 1.0f;
    public float rt_x, rt_y,rt_z;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var ob = gameObject;
        var rb = GetComponent<Rigidbody>();
        transform.Translate(new Vector3(ts_x * Time.deltaTime, ts_y * Time.deltaTime, ts_z * Time.deltaTime));
        transform.Rotate(new Vector3(rt_x * Time.deltaTime, rt_y * Time.deltaTime, rt_z * Time.deltaTime));
    }
}
