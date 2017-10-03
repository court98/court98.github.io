using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClip : MonoBehaviour {
    public AudioClip Thump;
    public AudioClip BombSound;
    AudioSource audiosource;

    // Use this for initialization
    void Start() {
        audioSource = GetComponent<AudioSource>();


    }
    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(Thump, 0.F);
    }
}
    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(BombSound, 0.7F);
    }
}

// Update is called once per frame
void Update () {
		
	}
}

