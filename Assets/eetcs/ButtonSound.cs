using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;    
    public AudioClip clickSound;       

    public void PlayClickSound()
    {
        Debug.Log("Clique detectado");   

        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);  
        }
        else
        {
            Debug.LogWarning("AudioSource ou ClickSound não está definido no Inspector!");
        }
    }
}
