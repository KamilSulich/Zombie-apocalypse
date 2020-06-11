using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    int HP;
    void Start()
    {
        SetHP();
    }

    private void SetHP()
    {
        if (PlayerPrefs.GetInt("difficulty") == 1)
        {
            HP = 50000;
        }
        else if (PlayerPrefs.GetInt("difficulty") == 2)
        {
            HP = 40000;
        }
        else
        {
            HP = 30000;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "enemy")
        {
            HP = HP-50;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            //player die

        }
    }
}
