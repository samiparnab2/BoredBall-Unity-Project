using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShopClick : MonoBehaviour,IPointerClickHandler
{
        public Animator shopentry;
    public void OnPointerClick(PointerEventData p)
    {
        shopentry.SetTrigger("ShopEntry");    }
}
