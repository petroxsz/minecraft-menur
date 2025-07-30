using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneClickLoader : MonoBehaviour
{
    public AudioSource clickSound;

    public void LoadSceneWithSound(string sceneName)
    {
        StartCoroutine(PlayClickThenLoad(sceneName));
    }

    IEnumerator PlayClickThenLoad(string sceneName)
    {
        if (clickSound != null && clickSound.clip != null)
        {
            clickSound.Play();
            yield return new WaitForSeconds(clickSound.clip.length);  
        }

        SceneManager.LoadScene(sceneName);
    }
}
