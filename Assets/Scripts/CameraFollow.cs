﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    public float offsetXDist = 2;
    public float offsetYDist = 2;
    public float offsetZDist = 2;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(FollowPlayer());
        player = GameObject.FindGameObjectWithTag("Player");
        offsetXDist += player.transform.position.x;
        offsetYDist += player.transform.position.y;
        offsetZDist += player.transform.position.z;
        offset = transform.position - new Vector3(offsetXDist, offsetYDist, offsetZDist);
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null)
            transform.position = player.transform.position + offset;
    }

    IEnumerator FollowPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        yield return new WaitUntil(() => player != null);
        offsetXDist += player.transform.position.x;
        offsetYDist += player.transform.position.y;
        offsetZDist += player.transform.position.z;
        offset = transform.position - new Vector3(offsetXDist, offsetYDist, offsetZDist);
    }
}
