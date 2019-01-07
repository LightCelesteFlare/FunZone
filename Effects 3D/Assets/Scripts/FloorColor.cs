using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorColor : MonoBehaviour {
    public float[] R, B, G;
    public float startTimer = 0f;
    public float waitTime = 3f;
    public int tl = 1;
    public GameObject controllerTag;

    // Use this for initialization
    void Start () {
        controllerTag = GameObject.FindGameObjectWithTag("PartController");
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Renderer>().material.color = new Color(R[tl], G[tl], B[tl]);
        startTimer += Time.deltaTime;
        if (startTimer >= waitTime)
        {
            if (tl == 1)
            {
                tl = 0;
            }
            else
            {
                tl = 1;
            }
            startTimer = 0;
        }
        //if (controllerTag == null)
        //{
        //    Destroy(gameObject);
        //}
    }
}
