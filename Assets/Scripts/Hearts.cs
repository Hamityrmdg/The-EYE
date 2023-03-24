using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class Hearts : MonoBehaviour
{
    public GameObject spawnPoint;
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private int maxHealth;
    [SerializeField] private int healthRechargeDuration;

    public int health;

    private const string HealthKey = "Health";
    private const string HealthReadyKey = "HealthReady";
    private void Start()
    {
        
        health = PlayerPrefs.GetInt(HealthKey, maxHealth);
        if (health == 0)
        {
            string healthReadyString = PlayerPrefs.GetString(HealthReadyKey, string.Empty);
            if (healthReadyString == string.Empty) { return; }
            DateTime healthReady = DateTime.Parse(healthReadyString);

            if (DateTime.Now > healthReady)
            {
                health = maxHealth;
                PlayerPrefs.SetInt(HealthKey, health);
            }
        }
        healthText.text = $"Play ({health})";
    }

    private void OnTriggerEnter(Collider other)
    {

        
            if (1 < health)
            {
                if (other.tag == "Respawn")
                {
                    this.transform.position = spawnPoint.transform.position;
                    //_speed.speed = 0;
                }
            }
        
    }

    public void Play()
    {
        if (1 < health)
        {
            this.transform.position = spawnPoint.transform.position;
        }
        if (health < 1) { return; }
        health--;
        PlayerPrefs.SetInt(HealthKey, health);
        if (health == 0)
        {
            DateTime healthReady = DateTime.Now.AddMinutes(healthRechargeDuration);
            PlayerPrefs.SetString(HealthReadyKey, healthReady.ToString());
        }
        SceneManager.LoadScene(1);

    }
}