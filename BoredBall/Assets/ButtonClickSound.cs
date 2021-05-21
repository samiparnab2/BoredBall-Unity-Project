using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonClickSound : MonoBehaviour,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData p)
    {
      FindObjectOfType<AudioManager>().Play("click");
    }
}
