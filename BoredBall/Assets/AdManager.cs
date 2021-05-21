using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdManager : MonoBehaviour
{
    //fill these infos from the  inspector(based on your unity profile)
    //get these id from unity dashboard 
        public string playStoreId;
        public string appStoreId;
        public string interstitialAd;
        public string rewardedAd;
        public bool isPlayStore,isTestAd;
        //adReady,adError,adStart,adFailed,adSkipped,adFinished;
    // Start is called before the first frame update
    void Start()
    {
       /* adReady=false;
        adError=false;
        adStart=false;
        adFinished=false;
        adFailed=false;
        adSkipped=false;*/
        InitializeAd();
    }

    private void InitializeAd()
    {
        if(isPlayStore)
        {
            Advertisement.Initialize(playStoreId,isTestAd);
            return;
        }
        Advertisement.Initialize(appStoreId,isTestAd);

    }
    public void PlayInterstitialAd()
    {
        if(!Advertisement.IsReady(interstitialAd))
        {
            return;
        }
        FindObjectOfType<AudioManager>().Mute();
        Advertisement.Show(interstitialAd);
    }
    public void PlayRewardedAd()
    {
         
        if(!Advertisement.IsReady(rewardedAd))
        {
            return;
        }
        FindObjectOfType<AudioManager>().Mute();
        Advertisement.Show(rewardedAd);
    }

   /* public void OnUnityAdsReady(string placementId)
    {
            adReady=true;
    }
     public void OnUnityAdsDidError(string message)
     {
            adError=true;
     }
      public void OnUnityAdsDidStart(string placementId)
      {
          adStart=true;
      }
       public void OnUnityAdsDidFinish(string placementId,ShowResult showResult)
       {
                adPlacementId=placementId;
            switch (showResult)
            {
                case ShowResult.Failed:
                                    adFailed=true;
                break;
                case ShowResult.Skipped:
                                    adSkipped=true;
                break;
                case ShowResult.Finished:
                                        adFinished=true;
                break;
            }
        
       }*/

    
}
