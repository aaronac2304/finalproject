using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(AudioLowPassFilter))]

public class Occlusion : MonoBehaviour
{
    AudioSource audioSource;

    private Vector3 sourcePos;
    private Vector3 playerPos;
    private Vector3 rayDirection;
    private Vector3 fwd = Vector3.forward;

    float angle;


    private bool obst;
    public bool isDirectional = false;



    public GameObject player;

    private bool isObstructed;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        sourcePos = transform.position;
        playerPos = player.transform.position;
        rayDirection = playerPos - sourcePos;

        //raycastOcclusion();

        if (isDirectional == true)
        {
            audioSource.volume = directionalSound();
        }

        Debug.Log(angle);
    }

    private float directionalSound()
    {
        angle = Vector3.Angle(fwd, rayDirection);
        float vol = angle / 180f;
        return vol;

    }

    void raycastOcclusion()
    {
        float dist = Vector3.Distance(sourcePos, playerPos);
        Debug.DrawRay(sourcePos, rayDirection, Color.green);
        dist = Vector3.Distance(playerPos, sourcePos);

        RaycastHit hit;

        bool obst = Physics.Raycast(sourcePos, rayDirection, out hit, dist);

        if (obst == false)
        {
            GetComponent<AudioLowPassFilter>().cutoffFrequency = 22000;
        }
        else { GetComponent<AudioLowPassFilter>().cutoffFrequency = 2000; }
    }
}
