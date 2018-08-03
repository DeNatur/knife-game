﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour {
    public GameObject destroyPoint;

    // Use this for initialization
    void Start()
    {
        destroyPoint = GameObject.Find("CubeDestroyer");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < destroyPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}