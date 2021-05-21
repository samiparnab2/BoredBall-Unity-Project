using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using  UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class WatchAd : MonoBehaviour,IPointerClickHandler,IUnityAdsListener
{
    string adPlacementId="rewardedVideo";
    public AdManager getLifeAd;
    public GameManagement g;
 public void OnPointerClick(PointerEventData p)
{
    getLifeAd.PlayRewardedAd();
}
void Start()
{
    
    Advertisement.AddListener(this);
}

public void ShowAd()
{
    int a;
    if(PlayerPrefs.HasKey("interadcount"))
    {
        a=PlayerPrefs.GetInt("interadcount");
        a++;
        PlayerPrefs.SetInt("interadcount",a);
        if(a%5==0)
        {
            getLifeAd.PlayInterstitialAd();

        }
    }
    else
    {
        PlayerPrefs.SetInt("interadcount",1);
        
    }
    PlayerPrefs.Save();
}


public void OnUnityAdsReady(string placementId)
    {
    }
     public void OnUnityAdsDidError(string message)
     {
     }
      public void OnUnityAdsDidStart(string placementId)
      {
      }
       public void OnUnityAdsDidFinish(string placementId,ShowResult showResult)
       {
            FindObjectOfType<AudioManager>().NotMute();
            switch (showResult)
            {
                case ShowResult.Failed:
                break;
                case ShowResult.Skipped:
                break;
                case ShowResult.Finished:
               
                        if(placementId==adPlacementId)
                        {
                            int x= PlayerPrefs.GetInt("totalcoins");
                             PlayerPrefs.SetInt("totalcoins",x-g.coin);
                              PlayerPrefs.Save();
                            Debug.Log("Start ad");
                           PlayerPrefs.SetInt("adtotalmiss",g.totalmiss);
                           PlayerPrefs.SetInt("adcoin",g.coin);
                           PlayerPrefs.SetInt("adscore",g.score);
                           Debug.Log("Set");
                           PlayerPrefs.Save();
                           Debug.Log("Saved");
                            SceneManager.LoadScene(1,LoadSceneMode.Single);

                        }
                        
                break;
            }
        
       }


}
