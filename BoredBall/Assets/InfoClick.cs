using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InfoClick : MonoBehaviour,IPointerClickHandler
{
    public Animator info;
 public void OnPointerClick(PointerEventData p)
 {
     info.SetTrigger("InfoEntry");
 }
}
