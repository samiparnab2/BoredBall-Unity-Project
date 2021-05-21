using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class QuitClick : MonoBehaviour,IPointerClickHandler
{
    public Animator quitentry;
     public void OnPointerClick(PointerEventData p)
     {
            quitentry.SetTrigger("QuitEntry");
     }
}
