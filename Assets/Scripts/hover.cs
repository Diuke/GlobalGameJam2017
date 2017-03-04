using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class hover : MonoBehaviour{
    private GameObject bafle;
    private AudioSource sfx;
    void Start() {
        bafle = GameObject.Find("Bafle");
        sfx = GameObject.Find("sfx").GetComponent<AudioSource>();
    }

    public void playHover()
    {
        bafle.transform.position = new Vector3(140.8f, 7.2f, -125);
        sfx.Play();
    }

    public void tutorialHover()
    {
        bafle.transform.position = new Vector3(179.4f, 7.2f, -125);
        sfx.Play();
    }

    public void creditosHover()
    {
        bafle.transform.position = new Vector3(219.6f, 7.2f, -125);
        sfx.Play();
    }

    public void salirHover()
    {
        bafle.transform.position = new Vector3(260.4f, 7.2f, -125);
        sfx.Play();
    }

    public void HoverOut() {
        bafle.transform.position = new Vector3(196, 228.3f, -125);
    }
     
}
