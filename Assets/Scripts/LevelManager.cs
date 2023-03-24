using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    private int unlockedLevels;
    void Start()
    {
        unlockedLevels = PlayerPrefs.GetInt("unlockedLevels", 1);
        for (int i =0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < unlockedLevels; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void LoadLevel(int LevelIndex)
    {
        SceneManager.LoadScene(LevelIndex);
    }


    
}
