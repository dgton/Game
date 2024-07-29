using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void GotoLobby()
    {
        SceneManager.LoadScene("Lobby Scene");
    }

    public void GotoGame()
    {
        SceneManager.LoadScene("NewGame");
    }
}
