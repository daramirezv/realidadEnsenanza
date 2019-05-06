using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class codigoTodo : MonoBehaviour
{
    public AudioClip instruccionesIniciales;
    public AudioClip cuento;
    public AudioClip instruccionesPreguntas;
    public AudioClip pregunta1;
    public AudioClip pregunta2;
    public AudioClip pregunta3;
    public AudioClip pregunta4;
    public AudioClip pregunta5;
    public AudioClip pregunta6;
    public AudioClip pregunta7;
    public AudioClip final;

    public GameObject tablero1;
    public GameObject tablero2;
    public GameObject tablero3;
    public GameObject robot;
    public GameObject pared;

    public GameObject tablerofalse;
    public GameObject tablerotrue;

    public GameObject cerobien;
    public GameObject unobien;
    public GameObject dosbien;
    public GameObject tresbien;
    public GameObject cuatrobien;
    public GameObject cincobien;
    public GameObject seisbien;
    public GameObject sietebien;

    private int correctas;

    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        correctas = 0;

        tablero1.SetActive(true);
        tablero2.SetActive(true);
        tablero3.SetActive(true);
        robot.SetActive(true);
        pared.SetActive(true);

        tablerofalse.SetActive(false);
        tablerotrue.SetActive(false);

        cerobien.SetActive(false);
        unobien.SetActive(false);
        dosbien.SetActive(false);
        tresbien.SetActive(false);
        cuatrobien.SetActive(false);
        cincobien.SetActive(false);
        seisbien.SetActive(false);
        sietebien.SetActive(false);

        musicSource.clip = instruccionesIniciales;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Se ejecuta el cuento si las instrucciones terminaron
        if (!musicSource.isPlaying && musicSource.clip == instruccionesIniciales)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.Any))
            {
                musicSource.clip = cuento;
                musicSource.Play();
            }
        }

        //Se ejecutan las instrucciones de las preguntas el cuento termina
        else if (!musicSource.isPlaying && musicSource.clip == cuento)
        {
             musicSource.clip = instruccionesPreguntas;
             musicSource.Play();
        }

        //Se ejecuta la pregunta 1
        else if (!musicSource.isPlaying && musicSource.clip == instruccionesPreguntas)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.Any))
            {
                tablerofalse.SetActive(true);
                tablerotrue.SetActive(true);
                tablero1.SetActive(false);
                tablero2.SetActive(false);
                tablero3.SetActive(false);
                musicSource.clip = pregunta1;
                musicSource.Play();
            }
        }

        //Se ejecuta la pregunta 2 y se evalua la pregunta 1
        else if (!musicSource.isPlaying && musicSource.clip == pregunta1)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.LeftHand))
            {
                correctas++;
                musicSource.clip = pregunta2;
                musicSource.Play();
            }

            else if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.RightHand))
            {
                musicSource.clip = pregunta2;
                musicSource.Play();
            }
        }

        //Se ejecuta la pregunta 3 y se evalua la pregunta 2
        else if (!musicSource.isPlaying && musicSource.clip == pregunta2)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.LeftHand))
            {
                correctas++;
                musicSource.clip = pregunta3;
                musicSource.Play();
            }

            else if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.RightHand))
            {
                musicSource.clip = pregunta3;
                musicSource.Play();
            }
        }

        //Se ejecuta la pregunta 4 y se evalua la pregunta 3
        else if (!musicSource.isPlaying && musicSource.clip == pregunta3)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.LeftHand))
            {
                musicSource.clip = pregunta4;
                musicSource.Play();
            }

            else if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.RightHand))
            {
                correctas++;
                musicSource.clip = pregunta4;
                musicSource.Play();
            }
        }

        //Se ejecuta la pregunta 5 y se evalua la pregunta 4
        else if (!musicSource.isPlaying && musicSource.clip == pregunta4)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.LeftHand))
            {
                correctas++;
                musicSource.clip = pregunta5;
                musicSource.Play();
            }

            else if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.RightHand))
            {
                musicSource.clip = pregunta5;
                musicSource.Play();
            }
        }

        //Se ejecuta la pregunta 6 y se evalua la pregunta 5
        else if (!musicSource.isPlaying && musicSource.clip == pregunta5)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.LeftHand))
            {
                musicSource.clip = pregunta6;
                musicSource.Play();
            }

            else if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.RightHand))
            {
                correctas++;
                musicSource.clip = pregunta6;
                musicSource.Play();
            }
        }

        //Se ejecuta la pregunta 7 y se evalua la pregunta 6
        else if (!musicSource.isPlaying && musicSource.clip == pregunta6)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.LeftHand))
            {
                musicSource.clip = pregunta7;
                musicSource.Play();
            }

            else if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.RightHand))
            {
                correctas++;
                musicSource.clip = pregunta7;
                musicSource.Play();
            }
        }

        //Se ejecuta el final y se evalua la pregunta 7
        else if (!musicSource.isPlaying && musicSource.clip == pregunta7)
        {
            if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.LeftHand))
            {
                correctas++;
                musicSource.clip = final;
                musicSource.Play();
            }

            else if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.RightHand))
            {
                musicSource.clip = final;
                musicSource.Play();
            }
        }

        //Se muestra el resultado
        else if (!musicSource.isPlaying && musicSource.clip == final)
        {
            tablerofalse.SetActive(false);
            tablerotrue.SetActive(false);
            tablero1.SetActive(false);
            tablero2.SetActive(false);
            tablero3.SetActive(false);
            pared.SetActive(false);
            robot.SetActive(false);

            switch (correctas)
            {
                case 0:
                    cerobien.SetActive(true);
                    break;
                case 1:
                    unobien.SetActive(true);
                    break;
                case 2:
                    dosbien.SetActive(true);
                    break;
                case 3:
                    tresbien.SetActive(true);
                    break;
                case 4:
                    cuatrobien.SetActive(true);
                    break;
                case 5:
                    cincobien.SetActive(true);
                    break;
                case 6:
                    seisbien.SetActive(true);
                    break;
                default:
                    sietebien.SetActive(true);
                    break;
            }
        }
    }
}