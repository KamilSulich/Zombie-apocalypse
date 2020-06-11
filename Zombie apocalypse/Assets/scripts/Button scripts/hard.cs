using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hard : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerPrefs.SetInt("difficulty", 3);
        Application.LoadLevel("level");
    }
}
