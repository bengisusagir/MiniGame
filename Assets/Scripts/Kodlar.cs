using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Kodlar : MonoBehaviour
{
    public TextMeshProUGUI skor;
    public GameObject panel;
    public AudioSource audioSource;
    public AudioClip clip;
    public AudioClip buttonsound;
    public void Start()
    {
        skor.text = ("Son Skor = " + PlayerPrefs.GetString("Son Skor: "));
        if (skor.text == "Son Skor = 15 / 15")
        { skor.text = ("        YOU WIN"); }
        audioSource.PlayOneShot(clip);
    }

    public void Tuslar()
    {
        audioSource.PlayOneShot(buttonsound);
        panel.SetActive(true);
    }
    public void Kapa()
    {
        audioSource.PlayOneShot(buttonsound);
        panel.SetActive(false);
    }

    public void OyunaBasla()
    {
        audioSource.PlayOneShot(buttonsound);
        SceneManager.LoadScene("SampleScene");
        
    }
    public void ExitButton()
    {
        audioSource.PlayOneShot(buttonsound);
        Application.Quit();
        

    }

}
