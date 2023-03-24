using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    [SerializeField] private int damage;
    [SerializeField] private Saglýk _saglýk;

    private void OntriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        {
            damage0();
        }
    }
    void damage0()
    {
        _saglýk.playerHealth = _saglýk.playerHealth - damage;
        _saglýk.UpdateHealth();

    }
}

