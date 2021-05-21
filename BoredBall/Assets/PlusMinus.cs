using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlusMinus : MonoBehaviour,IPointerClickHandler
{
    public MusicController mc;
    public int operation;
    public void OnPointerClick(PointerEventData p)
    {
        mc.operation=operation;
    }
}
