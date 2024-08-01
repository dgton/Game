using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScript : MonoBehaviour
{
    public void GoSoup()
    {
        SceneManager.LoadScene("NewGame");
    }

    public void GoFolern()
    {
        SceneManager.LoadScene("FolernScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
