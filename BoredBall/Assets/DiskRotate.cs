using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskRotate : MonoBehaviour
{
       public float rotateforce=2f;
      float angle;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void FixedUpdate()
    {
        //GetComponent<Rigidbody>().AddTorque(transform.up*rotateforce);
       angle=rotateforce*Time.deltaTime;
        transform.Rotate(0,angle,0);
    }
}
