﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3D : MonoBehaviour {
 public GameObject mover;

        public float moveSpeed;



        // Use this for initialization

        void Start()
        {

        moveSpeed = 0.5f;

    }



        // Update is called once per frame

        void Update()
        {


        transform.Translate(moveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical"));//this code watch a youtube video for//
        }

    }


