using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
    public MatIcon[] maticons;
    public MatIcon select;
    public Text status;
    void Start()
    {
        int x;
        foreach(MatIcon m in maticons)
        {
            if(PlayerPrefs.HasKey("matbought"+m.dfindex))
            {
              x=PlayerPrefs.GetInt("matbought"+m.dfindex)  ;
              if(x==0)
                {
                    m.bought=false;
                    m.unlocked=false;
                }
                else if(x==1)
                {
                    m.bought=false;
                    m.unlocked=true;
                }
                else if(x==2)
                {
                    m.bought=true;
                    m.unlocked=true;
                }
                if(PlayerPrefs.GetInt("highestscore")>=m.reqsc && PlayerPrefs.GetInt("matbought"+m.dfindex)==0)
                {
                    m.unlocked=true;
                    PlayerPrefs.SetInt("matbought"+m.dfindex,1);
                }
            }
            else
            {
                if(m.bought && m.unlocked)
                {
                    PlayerPrefs.SetInt("matbought"+m.dfindex,2);
                }
                else if(!m.bought && m.unlocked)
                {
                    PlayerPrefs.SetInt("matbought"+m.dfindex,1);
                }
                else if(!m.bought && !m.unlocked)
                {
                    PlayerPrefs.SetInt("matbought"+m.dfindex,0);
                }
            }
        }
        PlayerPrefs.Save();
    
    }
    public void ChangeSelected(int i)
    {
        int x;
        foreach(MatIcon m in maticons)        
        {
            if(m.dfindex==i)
            {
                select=m;
                m.Fade();
                m.selected=true;
                x=PlayerPrefs.GetInt("matbought"+m.dfindex);
                if(x==0)
                {
                    status.text="MAKE A SCORE OF "+m.reqsc+" TO UNLOCK";
                }
                else if(x==1)
                {
                    status.text="SPEND "+m.price+" TO BUY";
                }
                else if(x==2)
                {
                    status.text="";
                }
            }
            else
            {
                m.UnFade();
                m.selected=false;
            }
        }
    }
}
