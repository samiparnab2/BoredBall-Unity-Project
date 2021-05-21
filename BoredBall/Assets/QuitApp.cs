using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class QuitApp : MonoBehaviour,IPointerClickHandler
{
    
    public void OnPointerClick(PointerEventData p)
    {
         Application.Quit();
    }
}


