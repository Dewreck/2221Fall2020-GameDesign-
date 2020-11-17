using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ButtonBehavior : MonoBehaviour
{
    public Color newColor;
    public Color defaultColor;
    public MeshRenderer meshR;
    // Start is called before the first frame update
    void Start()
    {
        meshR = GetComponent<MeshRenderer>();
        meshR.material.color = defaultColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        meshR.material.color = newColor;
    }

    private void OnTriggerExit(Collider other)
    {
        meshR.material.color = defaultColor;
    }
}
