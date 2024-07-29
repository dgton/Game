using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject Audio;
    private TextMeshProUGUI textMeshPro;
    public GameObject Success;
    public GameObject Fail;
    private Image sprite;
    public GameObject ComboText;
    public GameObject Perfectnum;
    public GameObject Missnum;
    public GameObject PM;
    public GameObject LobbyButton;
    public GameObject RestartButton;
    private void Start()
    {
        sprite = GetComponent<Image>();
        sprite.color = Color.clear;
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if (Audio.GetComponent<AudioSource>().time >= Audio.GetComponent<AudioSource>().clip.length)
        {
            ActivePanel("Success");
        }
    }
    public void ActivePanel(string PF)
    {
        if(PF == "Success")
        {
            ComboText.GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0, 0);
            sprite.color = new Color(0, 0, 0, 1);
            Success.SetActive(true);
            PM.SetActive(true);
            Perfectnum.SetActive(true);
            Perfectnum.GetComponent<TextMeshProUGUI>().text = Combo.Perfect.ToString();
            Missnum.SetActive(true);
            Missnum.GetComponent<TextMeshProUGUI>().text = Combo.Miss.ToString();
            LobbyButton.SetActive(true);
            RestartButton.SetActive(true);
        }

        else if(PF == "Fail")
        {
            ComboText.GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0, 0);
            sprite.color = new Color(0, 0, 0, 1);
            Audio.GetComponent<AudioSource>().Stop();
            NoteObject.speed = 0;
            Fail.SetActive(true);
            PM.SetActive(true);
            Perfectnum.SetActive(true);
            Perfectnum.GetComponent<TextMeshProUGUI>().text = Combo.Perfect.ToString();
            Missnum.SetActive(true);
            Missnum.GetComponent<TextMeshProUGUI>().text = Combo.Miss.ToString();
            LobbyButton.SetActive(true);
            RestartButton.SetActive (true);
        }
    }

    
}
