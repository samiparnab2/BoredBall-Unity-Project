using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MatIcon : MonoBehaviour,IPointerClickHandler
{
    public bool bought,selected,unlocked;
    public int reqsc,price,dfindex;
    public ShopManager sm;
        public void OnPointerClick(PointerEventData p)
        {
                sm.ChangeSelected(dfindex);
        }
   public void Fade()
   {
       GetComponent<Image>().color=new Color(255,255,255,0.6f);
   }
   public void UnFade()
   {
    GetComponent<Image>().color=new Color(255,255,255,1f);
       
   }
}
