using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfTiler : MonoBehaviour
{
    public GameObject prefab;

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.GetComponent<Camera>())
        {
            var up = GameObject.Instantiate<GameObject>(prefab);
            up.transform.position = transform.position + Vector3.forward * 1000f;
            var down = GameObject.Instantiate<GameObject>(prefab);
            down.transform.position = transform.position - Vector3.forward * 1000f;
            var left = GameObject.Instantiate<GameObject>(prefab);
            left.transform.position = transform.position - Vector3.right * 1000f;
            var right = GameObject.Instantiate<GameObject>(prefab);
            right.transform.position = transform.position + Vector3.right * 1000f;
        }
    }
}
