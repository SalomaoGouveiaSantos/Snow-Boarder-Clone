using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private SurfaceEffector2D surfaceEffector;

    [SerializeField] private float torqueAmount = 1f;
    [SerializeField] private float boostSpeed = 30f;
    [SerializeField] private float baseSpeed = 20f;

    private bool canMove = true;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    private void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }
    public void DisableControls()
    {
        canMove = false;
    }
    private void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        { 
            surfaceEffector.speed = boostSpeed;
        }
        else
        {
            surfaceEffector.speed = baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddTorque(-torqueAmount);
        }
    }
}
