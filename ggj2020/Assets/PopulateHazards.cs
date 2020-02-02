using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateHazards : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteriodPrefab;
    void Start()
    {

        for (int i = 0; i < 200; i++) {
            var a = GameObject.Instantiate<GameObject>(asteriodPrefab);
            var rn = Random.Range(0.01f, 1f);
            var r = Mathf.Sqrt(rn) * 400;
            var theta = Random.Range(0, Mathf.PI * 2);
            Vector3 pos = new Vector3(Mathf.Cos(theta), 0, Mathf.Sin(theta)) * r;
            a.transform.position = pos;
            var s = Random.Range(15f, 50f);
            a.transform.localScale = new Vector3(s,s,s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
