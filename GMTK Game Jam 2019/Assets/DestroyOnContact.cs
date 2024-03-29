﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "Player"
            //&& col.gameObject.tag != "PlayerBullet"
            && col.gameObject.tag != "Orbitter")
        {
            Destroy(col.gameObject);
            if (audioClip != null)
            {
                audioSource.pitch = Random.Range(0.6f, 1.5f);
                audioSource.PlayOneShot(audioClip);
            }
        }
    }
}
