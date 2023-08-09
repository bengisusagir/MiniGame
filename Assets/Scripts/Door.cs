using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    private int counter;
    public TextMeshProUGUI tmp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("door"))
        {
            counter++;
            tmp.text = counter.ToString()+ " / 15";
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
