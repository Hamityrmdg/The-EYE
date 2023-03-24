using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasar : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private Saglýk _saglýk;
    
    private void OnTriggerEnter(Collider collision)
        
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
       
        }
    }
    void Damage()
    {
        _saglýk.playerHealth = _saglýk.playerHealth - damage;
        _saglýk.UpdateHealth();
       
    }
}
