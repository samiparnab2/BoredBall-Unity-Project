using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManagement : MonoBehaviour
{
    public bool fall;
    public int score,coin,totalmiss,life;
    public GameObject b,mcam,high;
    public Text diskpaseedtext,missedtext,scoretext;
    public Animator gameoverAnimation;//highscoreanim
    public WatchAd wa;
    int tmpcoin;
    // Start is called before the first frame update
   
    void Start()
    {
          Screen.sleepTimeout = SleepTimeout.NeverSleep;
       fall=false;
       life=5;

       if(PlayerPrefs.HasKey("adtotalmiss"))
       {
       totalmiss=PlayerPrefs.GetInt("adtotalmiss");
       PlayerPrefs.DeleteKey("adtotalmiss");
       }
       else if(!PlayerPrefs.HasKey("adtotalmiss"))
       {
       totalmiss=0;
       }


        if(PlayerPrefs.HasKey("adcoin"))
       {
       coin=PlayerPrefs.GetInt("adcoin");
       PlayerPrefs.DeleteKey("adcoin");
       }
       else if(!PlayerPrefs.HasKey("adcoin"))
       {
         coin=0;
       }
       

       if(PlayerPrefs.HasKey("adscore"))
       {
       score=PlayerPrefs.GetInt("adscore");
       PlayerPrefs.DeleteKey("adscore");
       }
       else if(!PlayerPrefs.HasKey("adscore"))
       {
       score=0;
       }
       PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
            if(fall)
            {

               fall=false;
             GameObject.Find("life"+life.ToString()).GetComponent<Lifegone>().gone=true;
           
            life--;
            if(life==0)
            {
                    gameoverAnimation.SetTrigger("gameOverTrigger");
                     diskpaseedtext.text=coin.ToString()+" x50";
                     
                    if(PlayerPrefs.HasKey("totalcoins"))
                    {
                        tmpcoin=PlayerPrefs.GetInt("totalcoins");
                    PlayerPrefs.SetInt("totalcoins",tmpcoin+coin);
                    
                    }
                    else if(!PlayerPrefs.HasKey("totalcoins"))
                    {
                        PlayerPrefs.SetInt("totalcoins",coin);
                        
                    }
                     missedtext.text="-"+totalmiss.ToString();
                     scoretext.text=score.ToString();

                     b.transform.position=new Vector3(0f,1.34f,3.013f);
                     b.SetActive(false);
                    if(PlayerPrefs.HasKey("highestscore") && PlayerPrefs.GetInt("highestscore")<score)
                    {
                        PlayerPrefs.SetInt("highestscore",score);
                        high.SetActive(true);
                      //  highscoreanim.SetTrigger("HighScoreHappend");
                    }
                    else if(!PlayerPrefs.HasKey("highestscore"))
                    {
                        PlayerPrefs.SetInt("highestscore",score);
                        high.SetActive(true);
                      //  highscoreanim.SetTrigger("HighScoreHappend");
                    }

                    
                    PlayerPrefs.Save();
                    wa.ShowAd();
                     /*ghdcgjgfchjfhjfj*/
            }
            else
            {
                b.transform.parent=null;
                b.transform.rotation=Quaternion.identity;
                b.GetComponent<Couple>().ground.transform.rotation = Quaternion.identity;
                b.GetComponent<Couple>().ground.transform.Rotate(0,20,0);
       b.transform.position=new Vector3(0,1.94f,3.013f);
            }
               
            }
    }
    
}
