﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject target;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
     offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 delta = offset - (transform.position - target.transform.position);
        transform.position += delta;
	}
}
