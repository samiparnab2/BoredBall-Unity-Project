using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MatShop : MonoBehaviour,IPointerClickHandler
{
    public MatManager mg;
        public void OnPointerClick(PointerEventData p)
        {
                mg.Change(1);
        }

}
