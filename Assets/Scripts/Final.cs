using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    
    public int sahne_id;
    private int currentLevel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            SceneManager.LoadScene(sahne_id);
            currentLevel = SceneManager.GetActiveScene().buildIndex;

            if(currentLevel >= PlayerPrefs.GetInt("unlockedLevels"))
            {
                PlayerPrefs.SetInt("unlockedLevels", currentLevel + 1);
            }
        }
    }
}
