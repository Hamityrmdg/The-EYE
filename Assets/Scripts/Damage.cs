using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    [SerializeField] private int damage;
    [SerializeField] private Sagl�k _sagl�k;

    private void OntriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        {
            damage0();
        }
    }
    void damage0()
    {
        _sagl�k.playerHealth = _sagl�k.playerHealth - damage;
        _sagl�k.UpdateHealth();

    }
}

