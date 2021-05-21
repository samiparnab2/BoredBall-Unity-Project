using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicController : MonoBehaviour
{
    public int musicVolume;
    public Sprite volempty,volfill;
    public string musiccontroll,type;
    public int operation;

    void Start()
    {
        for(int i=1;i<=musicVolume;i++)
        {
            GameObject.Find(musiccontroll+i.ToString()).GetComponent<Image>().sprite=volfill;
        }

    }
     void Update()
    {
        if(operation==1)
        {
            VolumeUp();
        }
        else if(operation==-1)
        {
            VolumeDown();
        }
    }

    public void VolumeUp()
    {
        
        if(musicVolume<3)
        {
                musicVolume++;
                PlayerPrefs.SetInt(type+"volume",musicVolume);
                GameObject.Find(musiccontroll+musicVolume.ToString()).GetComponent<Image>().sprite=volfill;
                foreach (Sound s in FindObjectOfType<AudioManager>().sounds)
                {
                    if(s.type==type)
                    {
                        s.volume=(float)musicVolume/3;
                        s.source.volume=s.volume;
                    }
                }
                if(type=="music")
                {
                    FindObjectOfType<AudioManager>().musicvol=(float)musicVolume/3;
                }
                else if(type=="sfx")
                {
                     FindObjectOfType<AudioManager>().sfxvol=(float)musicVolume/3;

                }
                
        }
        operation=0;
    }

    public void VolumeDown()
    {
        if(musicVolume>0)
        {
                
                GameObject.Find(musiccontroll+musicVolume.ToString()).GetComponent<Image>().sprite=volempty;
                musicVolume--;
                PlayerPrefs.SetInt(type+"volume",musicVolume);
                foreach (Sound s in FindObjectOfType<AudioManager>().sounds)
                {
                    if(s.type==type)
                    {
                        s.volume=(float)musicVolume/3;
                        s.source.volume=s.volume;
                    }
                }
                if(type=="music")
                {
                    FindObjectOfType<AudioManager>().musicvol=(float)musicVolume/3;
                }
                else if(type=="sfx")
                {
                     FindObjectOfType<AudioManager>().sfxvol=(float)musicVolume/3;

                }
        }
        operation=0;
    }


}
