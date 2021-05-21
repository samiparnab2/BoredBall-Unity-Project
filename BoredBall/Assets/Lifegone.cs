using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifegone : MonoBehaviour
{
    public bool gone;
    public int num;
    // Start is called before the first frame update
    
    // Update is called once per frame
   
    void Update()
    {
            
            if(gone && num<31)
            {
            num++;
            }
           
        if(gone && num%6==0)
        {
            if(!GetComponent<SpriteRenderer>().enabled)
            {GetComponent<SpriteRenderer>().enabled=true;
            }
            else if(GetComponent<SpriteRenderer>().enabled)
            {
                GetComponent<SpriteRenderer>().enabled=false;
            }
        }
        if(gone && num>=30)
        {GetComponent<SpriteRenderer>().enabled=false;
        }
    }
}
