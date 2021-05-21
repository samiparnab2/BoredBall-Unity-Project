using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ExitButtonPressed : MonoBehaviour,IPointerClickHandler
{
    public Animator goButtonPress;
   public void OnPointerClick(PointerEventData p)
    {
      goButtonPress.SetTrigger("gobPressed");
    }

    
}
