using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string nextScene;
    public Animator fadeAnimator;

    public void LoadNextScene()
    {
        Debug.Log("load started");
        StartCoroutine(LoadSceneWithCrossfade());
    }

    IEnumerator LoadSceneWithCrossfade()
    {
        fadeAnimator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nextScene);
    }
}
