﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	public float approachPosRate = 0.02f;
	public float approachRotRate = 0.02f;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
        if(target != null)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, approachPosRate);
            transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, approachRotRate);
        }
    }

    public void Cut()
    {
        if(target != null)
        {
            transform.position = target.position;
            transform.rotation = target.rotation;
        }
    }
}
