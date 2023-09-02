using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    private int counter;
    public TextMeshProUGUI tmp;
    public AudioClip clip;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("door"))
        {
            counter++;
            tmp.text = counter.ToString()+ " / 15";
            audioSource.PlayOneShot(clip);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("door")) 
        {
            
            Destroy(other);
        }
    }
}
