using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallMove : MonoBehaviour
{
    public bool jumpable = false;
    public float jumpforce;
    public int miss = 0;
    float sin, cos, x, z, r, rad = 3.013f;
    public GameObject tutorial;
    int firsttime;
    // Update is called once per frame
    void Start()
    {
        if (!PlayerPrefs.HasKey("firsttime"))
        {
            PlayerPrefs.SetInt("firsttime", 0);
            firsttime = 1;
        }
        else
        {
            firsttime = PlayerPrefs.GetInt("firsttime");
        }
    }
    void Update()
    {
        if (firsttime == 1)
        {
            tutorial.GetComponent<Text>().text = "TOUCH ANYWHERE TO MAKE THE BALL JUMP\n AND PASS IT THROUGH THE HOLE OF THE UPPER DISK";
            tutorial.SetActive(true);
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                tutorial.SetActive(false);
                firsttime = 0;
            }
        }

        x = transform.position.x;
        z = transform.position.z;
        r = Mathf.Sqrt((x * x) + (z * z));
        sin = z / r;
        cos = x / r;
        transform.position = new Vector3(rad * cos, transform.position.y, rad * sin);


        if (Input.touches[0].phase == TouchPhase.Began)
        {
            JumpButtonPress();
        }


    }
    public void JumpButtonPress()
    {
        if (jumpable)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpforce);

            FindObjectOfType<AudioManager>().Play("jump");
            miss += 1;
        }
    }

}
//3.013