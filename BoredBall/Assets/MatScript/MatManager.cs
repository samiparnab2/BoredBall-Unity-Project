using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatManager : MonoBehaviour
{
    public Mat[] mats;
    public int df;
    public Renderer ba,d1,d2,d3,d4,d5;
    void Start()
    {
        if(PlayerPrefs.HasKey("matdefault"))
        {
            df=PlayerPrefs.GetInt("matdefault");
        }
        else
        {
            df=0;
            PlayerPrefs.SetInt("matdefault",0);
            PlayerPrefs.Save();
        }
        RenderSettings.skybox=mats[df].skybox;
        ba.material=mats[df].ball;
        d1.material=mats[df].disk;
        d2.material=mats[df].disk;
        d3.material=mats[df].disk;
        d4.material=mats[df].disk;
        d5.material=mats[df].disk;

    }


    public void Change(int i)
    {
        df=i;
        PlayerPrefs.SetInt("matdefault",df);
        PlayerPrefs.Save();
        RenderSettings.skybox=mats[df].skybox;
        ba.material=mats[df].ball;
        d1.material=mats[df].disk;
        d2.material=mats[df].disk;
        d3.material=mats[df].disk;
        d4.material=mats[df].disk;
        d5.material=mats[df].disk;
    }

    
    
}
