using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    Transform tf;
    Vector3 localPosition;

    public float movementSpeed;
    public float offset;
    public float distance;

    void Start()
    {
        tf = GetComponent<Transform>();
        localPosition = tf.localPosition;
    }

    void Update()
    {
        tf.localPosition = localPosition + distance * Vector3.up * Mathf.Sin(movementSpeed * Time.time + offset);
    }
}
