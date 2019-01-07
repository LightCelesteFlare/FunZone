using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {

    public Vector3 Self;
    public float[] xyz = {1f, 0f, -1f };

	// Use this for initialization
	void Start () {
        Self = new Vector3(xyz[0], xyz[1], xyz[2]);

	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(xyz[0], xyz[1], xyz[2]);
        
	}
}
