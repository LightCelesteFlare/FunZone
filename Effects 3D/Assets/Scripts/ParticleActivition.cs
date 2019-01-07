using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivition : MonoBehaviour {

    public GameObject controllerTag;
    // Use this for initialization
    void Start () {
        controllerTag = GameObject.FindGameObjectWithTag("PartController");
	}
	
	// Update is called once per frame
	void Update () {

        if (controllerTag == null)
        {
            Destroy(gameObject);
        }
    }
}
//  GameObjectWithTag