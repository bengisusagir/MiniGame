using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Kodlar : MonoBehaviour
{
    public TextMeshProUGUI skor;
    public GameObject panel;
    public void Start()
    {
        skor.text = ("Son Skor = " + PlayerPrefs.GetString("Son Skor: "));
        if (skor.text == "Son Skor = 15 / 15")
        { skor.text = ("        YOU WIN"); }

    }

    public void Tuslar()
    {
        panel.SetActive(true);
    }
    public void Kapa()
    {
        panel.SetActive(false);
    }

    public void OyunaBasla()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitButton()
    {
        Application.Quit();

    }

}
