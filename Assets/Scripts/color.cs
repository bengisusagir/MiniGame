using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class color : MonoBehaviour
{
    public Material newMaterial;
    public GameObject cb1;
    public Renderer objectRenderer1;
    public GameObject cb2;
    public Renderer objectRenderer2;
    public GameObject cb3;
    public Renderer objectRenderer3;
    public GameObject cb4;
    public Renderer objectRenderer4;
    public void Start()
    {
        objectRenderer1 = cb1.GetComponent<Renderer>();
        objectRenderer2 = cb2.GetComponent<Renderer>();
        objectRenderer3 = cb3.GetComponent<Renderer>();
        objectRenderer4 = cb4.GetComponent<Renderer>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objectRenderer1.material = newMaterial;
            objectRenderer2.material = newMaterial;
            objectRenderer3.material = newMaterial;
            objectRenderer4.material = newMaterial;
        }
        
    }
}
