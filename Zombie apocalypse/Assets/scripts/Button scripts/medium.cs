using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medium : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerPrefs.SetInt("difficulty", 2);
        Application.LoadLevel("level");
    }
}
