using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDestroy : MonoBehaviour {
    //public AudioClip otherClip;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        //audioSource.clip = otherClip;
        //audioSource.Play();
    }
	
	// Update is called once per frame
	void Update () {

        if (!audioSource.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
