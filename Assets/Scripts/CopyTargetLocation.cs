﻿using UnityEngine;
using System.Collections;

public class CopyTargetLocation : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.position;
	}
}
