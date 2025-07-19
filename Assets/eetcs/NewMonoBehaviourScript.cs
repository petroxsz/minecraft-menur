using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void OnSingleplayerClick()
    {
        Debug.Log("Botão Singleplayer clicado!");
    }

    public void OnMultiplayerClick()
    {
        Debug.Log("Botão Multiplayer clicado!");
    }

    public void OnRealmsClick()
    {
        Debug.Log("Botão Realms clicado!");
    }

    public void OnOptionsClick()
    {
        Debug.Log("Botão Options clicado!");
    }

    public void OnQuitGameClick()
    {
        Debug.Log("Botão Quit Game clicado!");
    }
}
