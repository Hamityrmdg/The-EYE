using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasar : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private Sagl�k _sagl�k;
    
    private void OnTriggerEnter(Collider collision)
        
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
       
        }
    }
    void Damage()
    {
        _sagl�k.playerHealth = _sagl�k.playerHealth - damage;
        _sagl�k.UpdateHealth();
       
    }
}
