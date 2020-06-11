using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easy : MonoBehaviour
{
    void OnMouseDown()
    {
        
        PlayerPrefs.SetInt("difficulty", 1);
        Application.LoadLevel("level");     
    }    
}
