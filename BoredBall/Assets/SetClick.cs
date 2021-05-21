using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SetClick : MonoBehaviour,IPointerClickHandler
{
        public MatManager mg;
        public ShopManager smg;
        public Text st;
            public void OnPointerClick(PointerEventData p)
            {
                    if(smg.select.unlocked && smg.select.bought)
                    {
                        mg.Change(smg.select.dfindex);
                    }
                    else if(smg.select.unlocked && !smg.select.bought)
                    {
                        st.text="ITEM NOT BOUGHT";
                    }
                    else if(!smg.select.unlocked && !smg.select.bought)
                    {
                        st.text="ITEM NOT UNLOCKED";
                    }
            }

}
