using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.localPosition;
        v.y = Mathf.Sin(5.0f * Time.time);
        transform.localPosition = v;
    }
}
