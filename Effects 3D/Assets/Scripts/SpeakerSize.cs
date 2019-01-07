using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerSize : MonoBehaviour {

    public float SXmin = 2f, SXmax = 1.7f;
    float dx;
    public float size = 0f;
    public float flapperduration = 2;

    public bool toggle = false;
    public GameObject controllerTag;
    // Use this for initialization
    void Start () {
        dx = SXmax - SXmin;
    }
	
	// Update is called once per frame
	void Update () {
        controllerTag = GameObject.FindGameObjectWithTag("PartController");
        if (controllerTag != null)
        {
            toggle = true;
        }
        if (controllerTag == null)
        {
            toggle = false;
        }
        if (toggle == true) { 
        this.transform.localScale = new Vector3( SXmin + dx * Mathf.Sin(Time.fixedTime * flapperduration), 
                                                .2f, SXmax + dx * Mathf.Sin(Time.fixedTime * flapperduration));
        }
    }
}
