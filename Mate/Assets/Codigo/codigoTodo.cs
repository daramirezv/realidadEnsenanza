using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class codigoTodo : MonoBehaviour
{
    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;
    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = music1;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!musicSource.isPlaying)
        {
            if (SteamVR_Input._default.inActions.GrabPinch.GetStateUp(SteamVR_Input_Sources.LeftHand))
            {
                musicSource.clip = music2;
                musicSource.Play();
            }

            else if (SteamVR_Input._default.inActions.GrabPinch.GetStateUp(SteamVR_Input_Sources.RightHand))
            {
                musicSource.clip = music3;
                musicSource.Play();
            }
        }
    }
}