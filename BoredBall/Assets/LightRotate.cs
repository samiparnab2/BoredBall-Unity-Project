using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotate : MonoBehaviour
{
    // Start is called before the first frame update
    float speed,anglex;
   public bool light;
    public float time;
   public Light p1,p2;
    void Start()
    {
        speed=1f;
        anglex=0;
        light=false;
        time=20f;
         p1.enabled=false;
            p2.enabled=false;
    }

  
    void Update()
    {
       
        anglex=-speed*Time.deltaTime;
        transform.Rotate(anglex,0,0);
        time+=Time.deltaTime;
       
        if(time>=180)
        {
            time=0;
            if(light)
            {
            p1.enabled=false;
            p2.enabled=false;
            light=false;
            }
            else
            {
            GetComponent<LitBulb>().lit=true;
            light=true;
            }
        }
    }
}
