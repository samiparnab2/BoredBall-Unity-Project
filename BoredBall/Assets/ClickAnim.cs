using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
public class ClickAnim : MonoBehaviour,IPointerClickHandler
{
        public Animator allBuutonExit;
    public void OnPointerClick(PointerEventData p)
    {
        allBuutonExit.SetTrigger("MenuButtonPressed");    }
    
}