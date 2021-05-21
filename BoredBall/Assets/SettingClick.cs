using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingClick : MonoBehaviour,IPointerClickHandler
{
    public Animator setting;
 public void OnPointerClick(PointerEventData p)
 {
     setting.SetTrigger("SettingEntry");
 }
}