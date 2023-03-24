using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class Saglık : MonoBehaviour
{
  
    public int playerHealth;
    public int sahne_id;
    [SerializeField] private Image[] hearts;

    private void Awake()
    {
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++) {
            if (i < playerHealth)
            {
                hearts[i].color = Color.red;
            }
            else  {
                hearts[i].color = Color.black;
            }
            
        }
        if (playerHealth <= 0)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        
        SceneManager.LoadScene(sahne_id);
    }
}
