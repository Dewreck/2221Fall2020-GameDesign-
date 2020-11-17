using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public FloatData value;
    public GameObject spawnPoint;
    [SerializeField] private CharacterController myCharacterControllerScript;
    private void Start()
    {
        myCharacterControllerScript = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (value.value <= 0)
        {
            myCharacterControllerScript.enabled = false;
            transform.position = spawnPoint.transform.position;
            if (transform.position == spawnPoint.transform.position)
            {
                value.value = 100f;
                myCharacterControllerScript.enabled = true;
            }
        }
    }
}
