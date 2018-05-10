using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroler : MonoBehaviour {
    private Vector3 offset;
    public GameObject target;
	// Use this for initialization
	void Start () {
        offset = target.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position - offset;	
	}
}
