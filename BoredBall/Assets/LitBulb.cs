using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitBulb : MonoBehaviour
{
    public bool lit;
    int num=0;
    void Update()
    {
            if(lit)
            {
            num++;
            }
            else
            {
            num=0;
            }
        if(lit && num%6==0)
        {
            if(!GetComponent<LightRotate>().p1.enabled)
            {
            GetComponent<LightRotate>().p1.enabled=true;
            GetComponent<LightRotate>().p2.enabled=true;
            }
            else if(GetComponent<LightRotate>().p1.enabled)
            {
                
            GetComponent<LightRotate>().p1.enabled=false;
            GetComponent<LightRotate>().p2.enabled=false;
            }
        }
        if(lit && num>=30)
        {
               lit=false; 
               GetComponent<LightRotate>().p1.enabled=true;
            GetComponent<LightRotate>().p2.enabled=true;
        }
    }
}
