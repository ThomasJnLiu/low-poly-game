using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody playerbody;
    public Transform playerTransform;
    public int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //playerbody = GetComponentInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerTransform.Translate(moveSpeed * Input.GetAxis("Horizontal")*Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
        //Debug.Log("speed");

        
    }


}
