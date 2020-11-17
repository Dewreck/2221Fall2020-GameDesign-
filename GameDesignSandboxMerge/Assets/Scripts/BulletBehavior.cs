using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletBehavior : MonoBehaviour
{
    private Rigidbody rBody;
    public float bulletForce, bulletTime = 2f;

    private IEnumerator Start()
    {
        rBody = GetComponent<Rigidbody>();
        
        rBody.AddRelativeForce(Vector3.forward * bulletForce);
        yield return new WaitForSeconds(bulletTime);
        Destroy(gameObject);
    }
}
