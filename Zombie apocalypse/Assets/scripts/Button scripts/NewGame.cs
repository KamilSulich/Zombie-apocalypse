using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{
    public Transform SpawnPosition;

    public GameObject exitButton;
    public GameObject easyButton;
    public GameObject mediumButton;
    public GameObject hardButton;
    public GameObject NewGameButton;

    Vector3 easyButtonPossition= Vector3.zero;
    Vector3 mediumButtonPossition = Vector3.zero;
    Vector3 hardButtonPossition = Vector3.zero;

    void OnMouseDown()
    {
        CreateDifficultyButtons();
        DestroyOldButtons();

    }

    private void DestroyOldButtons()
    {
        Destroy(exitButton);
        Destroy(NewGameButton);
    }

    private void CreateDifficultyButtons()
    {
        easyButtonPossition.z = -1;
        easyButtonPossition.y = 5;

        mediumButtonPossition.z = -1;
        mediumButtonPossition.y = 1;

        hardButtonPossition.z = -1;
        hardButtonPossition.y = -3;

        Instantiate(easyButton, easyButtonPossition, SpawnPosition.rotation);
        Instantiate(mediumButton, mediumButtonPossition, SpawnPosition.rotation);
        Instantiate(hardButton, hardButtonPossition, SpawnPosition.rotation);
    }
}
