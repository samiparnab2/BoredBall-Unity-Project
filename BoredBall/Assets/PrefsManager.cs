using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrefsManager : MonoBehaviour
{
    public Text highscore,coins;
    public GameObject highestscoredisp;
    public MusicController mcontroll,sfxcontroll;
    void Awake()
    {
        if(PlayerPrefs.HasKey("totalcoins"))
        {
            coins.text=PlayerPrefs.GetInt("totalcoins").ToString();
        }
        else if(!PlayerPrefs.HasKey("totalcoins"))
        {
            coins.text="0";
            PlayerPrefs.SetInt("totalcoins",0);
        }
        if(PlayerPrefs.HasKey("highestscore"))
        {
            highscore.text=PlayerPrefs.GetInt("highestscore").ToString();
            highestscoredisp.SetActive(true);
        }
        if(PlayerPrefs.HasKey("musicvolume"))
        {
            mcontroll.musicVolume=PlayerPrefs.GetInt("musicvolume");
            FindObjectOfType<AudioManager>().musicvol=(float)mcontroll.musicVolume/3;
        }
        else
        { 
            PlayerPrefs.SetInt("musicvolume",3);
              mcontroll.musicVolume=3;
            FindObjectOfType<AudioManager>().musicvol=1f;
        }
        
        if(PlayerPrefs.HasKey("sfxvolume"))
        {
            sfxcontroll.musicVolume=PlayerPrefs.GetInt("sfxvolume");
            FindObjectOfType<AudioManager>().sfxvol=(float)sfxcontroll.musicVolume/3;
        }
        else
        {           
             PlayerPrefs.SetInt("sfxvolume",3);
                sfxcontroll.musicVolume=3;
            FindObjectOfType<AudioManager>().sfxvol=1f;
        
        }

        FindObjectOfType<AudioManager>().SetAll();
        PlayerPrefs.Save();
    }

    
    void Update()
    {
        
    }
}
