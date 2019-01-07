using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSong : MonoBehaviour {
    public GameObject Table;
    public GameObject Audio;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Audio != null)
            Instantiate(Audio, Table.transform.position, Quaternion.identity);
        }
    }
}
