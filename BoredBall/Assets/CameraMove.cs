using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 offset,temp;
    public Transform ball;
    // Start is called before the first frame update
    void Start()
    {
        offset.Set(0,1.3f,0);
        temp=transform.position;
    }

    // Update is called once per frame
    void Update()
    {  
        temp.y=ball.position.y;
        transform.position=temp+offset;
    }
}
