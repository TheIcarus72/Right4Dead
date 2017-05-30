﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    public Camera cam;
    private float shakeAmount = 0;
    public  CamShake camShake;


    public void Awake()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        if (camShake==null)
        {
            camShake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CamShake>();
        }

    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            Shake(0.1f, 0.2f);
        }
    }

    public void DoShake()
    {
        if (shakeAmount>0)
        {
            Vector3 camPos = cam.transform.position;
            float offsetX = Random.value * shakeAmount * 2 - shakeAmount;
            float offsetY = Random.value * shakeAmount * 2 - shakeAmount;

            camPos.x += offsetX;
            camPos.y += offsetY;

            cam.transform.position = camPos;
        }
    }

    public void EndShake()
    {
        CancelInvoke("DoShake");
        cam.transform.localPosition = Vector3.back;
    }

    public void Shake (float amt, float length)
    {
        shakeAmount = amt;
        InvokeRepeating("DoShake", 0, 0.01f);
        Invoke("EndShake", length);

    }
}