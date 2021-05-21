using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using  UnityEngine.SceneManagement;

public class PlayClick : MonoBehaviour,IPointerClickHandler
{
    // Start is called before the first frame update
    public Animator sceneExit;
    public void OnPointerClick(PointerEventData p)
    {
        sceneExit.SetTrigger("SceneExit");
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }
}
