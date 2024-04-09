using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xang;
    [SerializeField] float yang;
    [SerializeField] float zang;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        transform.Rotate(xang,yang,zang);
    }
}