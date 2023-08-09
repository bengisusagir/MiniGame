using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerp : MonoBehaviour
{
    public TextMeshProUGUI coun; 

    void Update()
    {
        PlayerPrefs.SetString("Son Skor: ", coun.text);
    }

}
