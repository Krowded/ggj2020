using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform tf;
    public float movementSpeed;
    public float rotationSpeed;

    void Start()
    {
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 forward = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            forward.z += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            forward.z -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            forward.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            forward.x += 1;
        }

        forward.Normalize();

        tf.position += forward * movementSpeed * Time.deltaTime;

        var angleBetweenForwards = Vector3.Angle(tf.forward, forward);
        angleBetweenForwards -= angleBetweenForwards > 180 ? 180 : 0; 
        
        var sign = Mathf.Sign(angleBetweenForwards);
        var angleToMove = Mathf.Min(rotationSpeed * Time.deltaTime, Mathf.Abs(angleBetweenForwards));
        tf.Rotate(0, - sign * angleToMove, 0);
    }
}
