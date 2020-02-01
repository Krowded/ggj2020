using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObjectScript : MonoBehaviour
{
    public Transform objectToFollow;
    private Transform tf;

    void Start()
    {
        tf = transform;
    }

    void Update()
    {
        tf.position = new Vector3(objectToFollow.position.x, tf.position.y, objectToFollow.position.z);
    }
}
