using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float maxSpeed = 7.5f;
   public float rotSpeed = 225f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler( 0, 0 , z);
        transform.rotation = rot;
        Vector3 pos = transform.position;

       
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        pos += rot * velocity;

        if(pos.y > 10)
        {
            pos.y = 10;
        }
        if(pos.y < -10)
        {
            pos.y = -10;
        }

        if(pos.x > 15)
        {
            pos.x = 15;
        }
        if(pos.x < -15)
        {
            pos.x = -15;
        }

        transform.position = pos;  
    }
}
