﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q)) {
            transform.Rotate(0, 0, -3);
         }
         if (Input.GetKey(KeyCode.E))
            transform.Rotate(0, 0, +3);
        }
    

       
}
