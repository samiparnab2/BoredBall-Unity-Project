using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entry : MonoBehaviour
{
    public Animator allbtn;
    // Start is called before the first frame update
    void Start()
    {
        allbtn.SetTrigger("BakToMenu");
        FindObjectOfType<AudioManager>().Play("background");
    }

}
