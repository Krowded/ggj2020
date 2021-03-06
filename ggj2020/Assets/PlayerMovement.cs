using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform tf;
    public float movementSpeed;
    public float rotationSpeed;
    public GameObject floor;
    public GameObject wall;

    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    void Start()
    {
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 forward = Vector3.zero;

        if (Input.GetKey(up))
        {
            forward.z += 1;
        }
        if (Input.GetKey(down))
        {
            forward.z -= 1;
        }
        if (Input.GetKey(left))
        {
            forward.x -= 1;
        }
        if (Input.GetKey(right))
        {
            forward.x += 1;
        }

        forward.Normalize();
        tf.position += forward * movementSpeed * Time.deltaTime;
        tf.localPosition = Vector3.Min(tf.localPosition, new Vector3(3.75f, tf.localPosition.y, 3.75f));
        tf.localPosition = Vector3.Max(tf.localPosition, new Vector3(-3.75f, tf.localPosition.y, -3.75f));

        var angleBetweenForwards = Vector3.Angle(tf.forward, forward);
        angleBetweenForwards -= angleBetweenForwards > 180 ? 180 : 0; 
        
        var sign = Mathf.Sign(angleBetweenForwards);
        var angleToMove = Mathf.Min(rotationSpeed * Time.deltaTime, Mathf.Abs(angleBetweenForwards));
        tf.Rotate(0, - sign * angleToMove, 0);
    }
}
