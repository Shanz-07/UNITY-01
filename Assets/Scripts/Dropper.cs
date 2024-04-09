using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour

{
    MeshRenderer m_Renderer;
    Rigidbody body;
    [SerializeField] int Eltime;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
        m_Renderer = GetComponent<MeshRenderer>();
        m_Renderer.enabled=false;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > Eltime)
        { 
        Debug.Log($"The time has elapsed to {Eltime} seconds");
            m_Renderer.enabled = true;
            body.useGravity = true;
        }
      
    }
}
