using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Couple : MonoBehaviour
{
  public GameObject ground,celing,temp,next,scoreinc,coininc;
  public ParticleSystem bp;
  public GameManagement gm;
  public Text scorebox,coin;
 //public Animator shakeCam;
  Vector3 groundy,celingy,nexty;
  int curentscore=0;
  float animtime;
  void Start()
    {
      
      animtime=0;
      groundy=ground.transform.position;
      celingy=celing.transform.position;
      nexty=next.transform.position;
      ground.GetComponent<DiskRotate>().rotateforce=Random.Range(50,150);
      celing.GetComponent<DiskRotate>().rotateforce=Random.Range(50,150);
      while(ground.GetComponent<DiskRotate>().rotateforce+20>=celing.GetComponent<DiskRotate>().rotateforce && ground.GetComponent<DiskRotate>().rotateforce-20<=celing.GetComponent<DiskRotate>().rotateforce)
      {
        celing.GetComponent<DiskRotate>().rotateforce=Random.Range(50,150);
      }
      
      next.GetComponent<DiskRotate>().rotateforce=Random.Range(50,150);
      while(celing.GetComponent<DiskRotate>().rotateforce+20>=next.GetComponent<DiskRotate>().rotateforce && celing.GetComponent<DiskRotate>().rotateforce-20<=next.GetComponent<DiskRotate>().rotateforce)
      {
        next.GetComponent<DiskRotate>().rotateforce=Random.Range(50,150);
      }
   scorebox.text=gm.score.ToString();
      coin.text=gm.coin.ToString();
    }
 void OnCollisionEnter(Collision coll)
	{

    if(coll.gameObject.name==ground.name)
    {
      bp.transform.position=new Vector3(transform.position.x,transform.position.y-0.5f,transform.position.z);
      bp.Play();
       transform.parent=coll.transform;
    }
    else if(coll.gameObject.name==celing.name)
    {
      bp.transform.position=new Vector3(transform.position.x,transform.position.y+0.5f,transform.position.z);
      bp.transform.Rotate(90,0,0);
      bp.Play();
    }
    
	}


  void OnCollisionStay(Collision coll)
 {
   
  if(coll.gameObject.name==celing.name)
    {
      transform.parent=coll.transform;
      
    }
   
   
   GetComponent<Rigidbody>(). angularVelocity = Vector3. zero;
    GetComponent<BallMove>().jumpable=true;
    if(coll.gameObject.name==celing.name)
    {
      if(transform.position.y>=celing.transform.position.y+0.5)
      {
          FindObjectOfType<AudioManager>().Play("rise");
         // shakeCam.SetTrigger("ShakeCam");
          
       
        temp=ground;
        ground=celing;
        celing=next;
        next=temp;
        ground.transform.position=groundy;
        celing.transform.position=celingy;
        next.transform.position=nexty;
        next.GetComponent<DiskRotate>().rotateforce=Random.Range(50,150);
      while(celing.GetComponent<DiskRotate>().rotateforce+20>=next.GetComponent<DiskRotate>().rotateforce && celing.GetComponent<DiskRotate>().rotateforce-20<=next.GetComponent<DiskRotate>().rotateforce)
      {
        next.GetComponent<DiskRotate>().rotateforce=Random.Range(50,150);
      }
      curentscore+=50-GetComponent<BallMove>().miss+1;
      gm.totalmiss+=GetComponent<BallMove>().miss-1;                          //rng
     GetComponent<BallMove>().miss=0;
      coininc.GetComponent<Text>().text="+1";
      coininc.SetActive(true);
    
      if(curentscore>0)
      {
        
      scoreinc.GetComponent<Text>().text="+"+curentscore.ToString();
      scoreinc.SetActive(true);
      
      }
      }
      
    }
    
 }

  void OnCollisionExit(Collision coll)
  {
    GetComponent<BallMove>().jumpable=false;
    if(coll.gameObject.tag=="Default")
    {
      transform.parent=null;
    }
    
    
  }
   void Update()
  {
      if(scoreinc.activeSelf)
      {
        if(animtime>=1)
        {
          animtime=0;
          scoreinc.SetActive(false);
          coininc.SetActive(false);
            gm.score+=curentscore;
            gm.coin+=1;
      scorebox.text=gm.score.ToString();
      coin.text=gm.coin.ToString();
      curentscore=0;
        }
        else
        {
        animtime+=Time.deltaTime;   
        }

      }
       if (transform.position.y<-1)    
    {
        FindObjectOfType<AudioManager>().Play("fail");
        
        //FindObjectOfType<AudioManager>().Pause("background");


    }
    if (transform.position.y<-2)    
    {
      gm.fall=true;
    }
  }
}
