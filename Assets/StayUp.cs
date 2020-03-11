using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayUp : MonoBehaviour
{
    public float targetY;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
    }
}
