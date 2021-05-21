using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class BuyClick : MonoBehaviour,IPointerClickHandler
{
    public ShopManager s;
    public Text st;
    int x,coi;
     public void OnPointerClick(PointerEventData p)
     {
         x=PlayerPrefs.GetInt("matbought"+s.select.dfindex);
         coi=PlayerPrefs.GetInt("totalcoins");
            if(x==1)
            {
                if(s.select.price<=coi)
                {
                    x=2;
                    coi-=s.select.price;
                    s.select.bought=true;
                    PlayerPrefs.SetInt("matbought"+s.select.dfindex,x);
                    PlayerPrefs.SetInt("totalcoins",coi);
                    st.text="BOUGHT";
                    PlayerPrefs.Save();
                }
            }
     }

}
