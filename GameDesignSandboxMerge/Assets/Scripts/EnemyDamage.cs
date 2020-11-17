using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damageAmount = 0.1f;
    public FloatData value;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("The Damage is " + damageAmount);
            value.value -= damageAmount;
        }

        
    }
    

}
