using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using  UnityEngine.SceneManagement;
using UnityEngine;
public class RestartGame : MonoBehaviour,IPointerClickHandler
{
    public int sceneindex;
    public void OnPointerClick(PointerEventData p)
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneindex,LoadSceneMode.Single);
    }
}
