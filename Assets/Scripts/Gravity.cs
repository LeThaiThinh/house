﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public CharacterController controller;

    public static float gravity = -9.81f;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

}
