using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTowards : MonoBehaviour
{
    public Transform goal;
    private Transform tf;

    void Start()
    {
        tf = transform;
    }

    void Update()
    {
        var angle = Vector3.SignedAngle(tf.up, (goal.position - tf.position).normalized, Vector3.up);
        if (Mathf.Abs(angle) > 2f)
        {
            tf.RotateAround(tf.position, Vector3.up, angle);
        }
    }
}
