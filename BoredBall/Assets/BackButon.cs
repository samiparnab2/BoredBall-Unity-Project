using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackButon : MonoBehaviour,IPointerClickHandler
{
    public Animator bck,bcktoall;
    public string trigger;
     public void OnPointerClick(PointerEventData p)
     {
            bck.SetTrigger(trigger);
            bcktoall.SetTrigger("BakToMenu");
     }
}
