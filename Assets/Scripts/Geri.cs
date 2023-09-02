using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geri : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttunsou;
    public void GeriDon()
    {
        audioSource.PlayOneShot(buttunsou);
        SceneManager.LoadScene("Giris");
    }
}
