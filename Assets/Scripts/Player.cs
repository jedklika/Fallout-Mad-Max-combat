﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    
    public float speed;
    private bool move=false;
    public GameObject point;
    private Vector3 target;

    void Start() {
       
    }
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            if (move == false)
                move = true;
            Instantiate(point,target,Quaternion.identity);
        }
        if (move == true)
            transform.position = Vector3.MoveTowards(transform.position,target,speed*Time.deltaTime);
    }
}
