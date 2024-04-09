using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] float movespeed=10f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        PlayerInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }
    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xvalue, 0, zvalue);
    }
    void PlayerInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Dont hit the walls !");
    }
}
