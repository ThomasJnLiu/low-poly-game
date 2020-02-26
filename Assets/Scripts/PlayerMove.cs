using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody playerbody;
    public Transform playerTransform;
    public int thrust;
    // Start is called before the first frame update
    void Start()
    {
        //playerbody = GetComponentInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //playerTransform.Translate(moveSpeed * Input.GetAxis("Horizontal")*Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
        //Debug.Log("speed");

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerbody.AddForce(-thrust, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerbody.AddForce(thrust, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerbody.AddForce(0, 0, thrust, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerbody.AddForce(0, 0, -thrust, ForceMode.Impulse);
        }
        
    }


}
