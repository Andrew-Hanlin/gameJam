﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Follow : MonoBehaviour
{

    public Transform followTransform;
    // public BoxCollider2D mapBounds;

    private float xMin, xMax, yMin, yMax;
    private float camY, camX;
    private float camOrthsize;
    private float cameraRatio;
    private Camera mainCam;
    private Vector3 smoothPos;
    public float smoothSpeed = 0.5f;

    private void Start()
    {
        //xMin = mapBounds.bounds.min.x;
        //xMax = mapBounds.bounds.max.x;
        //yMin = mapBounds.bounds.min.y;
        //yMax = mapBounds.bounds.max.y;
        mainCam = GetComponent<Camera>();
        camOrthsize = mainCam.orthographicSize;
        cameraRatio = (xMax + camOrthsize) / 2.0f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        camY = followTransform.position.y;
        camX = followTransform.position.x;
        smoothPos = Vector3.Lerp(this.transform.position, new Vector3(camX, camY, this.transform.position.z), smoothSpeed);
        this.transform.position = smoothPos;


    }
}
