using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public int ammoCount = 20;
    public GameObject prefab;
    public float bulletForce;
    public Transform instancer;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammoCount > 0)
        {
            Instantiate(prefab, instancer.position, instancer.rotation);
            ammoCount--;
        }
    }
}
