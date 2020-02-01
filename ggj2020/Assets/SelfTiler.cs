using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfTiler : MonoBehaviour
{
    public GameObject prefab;
    private const float size = 1000f;

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.GetComponent<Camera>())
        {
            var up = GameObject.Instantiate<GameObject>(prefab);
            up.transform.position = transform.position + Vector3.forward * size;
            var down = GameObject.Instantiate<GameObject>(prefab);
            down.transform.position = transform.position - Vector3.forward * size;
            var left = GameObject.Instantiate<GameObject>(prefab);
            left.transform.position = transform.position - Vector3.right * size;
            var right = GameObject.Instantiate<GameObject>(prefab);
            right.transform.position = transform.position + Vector3.right * size;

            var upLeft = GameObject.Instantiate<GameObject>(prefab);
            upLeft.transform.position = transform.position + size * new Vector3(-1, 0, 1);
            var upRight = GameObject.Instantiate<GameObject>(prefab);
            upRight.transform.position = transform.position + size * new Vector3(1, 0, 1);
            var downLeft = GameObject.Instantiate<GameObject>(prefab);
            downLeft.transform.position = transform.position + size * new Vector3(-1,0,-1);
            var downRight = GameObject.Instantiate<GameObject>(prefab);
            downRight.transform.position = transform.position + size * new Vector3(1,0,-1);
        }
    }
}
