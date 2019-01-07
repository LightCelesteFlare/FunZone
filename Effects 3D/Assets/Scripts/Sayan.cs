using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayan : MonoBehaviour {
    public float timer;
    public float timer2;
    public int ts = 0;
    public int tl = 0;
    public float waitTime = 30f;

    public GameObject Person;
    public GameObject hair;
    

    public GameObject lightGameObject;
    Vector3 v1;
    Vector3 v2;
    public GameObject Audio;
    public GameObject Powerup;
    // Use this for initialization
    void Start () {
        if (Person == null)
            Person = GameObject.FindWithTag("Sayan");

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            ts = 1;
            Instantiate(Audio, Person.transform.position, Quaternion.identity);
        }
        if (timer >= 7 && tl != 1)
        {
            tl = 1;
            // Set the position for Powerup
            v1 = new Vector3(Person.transform.position.x,
                             Person.transform.position.y,
                             Person.transform.position.z);

            Instantiate(Powerup, v1, Quaternion.identity);
            
            // Set the position (or any transform property)
            lightGameObject.transform.position = new Vector3(0f, hair.transform.position.y + .5f, 0f);
            Instantiate(lightGameObject, lightGameObject.transform.position, Quaternion.identity);         
        }
        if (ts == 1)
        {

            // Timer
            timer += Time.deltaTime;
            if (timer >= 7)
            gameObject.GetComponent<Renderer>().material.color = new Color(timer * .05f, timer * .05f, 0f, 255f);

            if (timer > waitTime)
            {
                ts = 0;
                timer = 0;
                gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0f, 255f);
                tl = 0;
            }
        }
    }
}


/*
 *             
 *       // Make a game object
                   GameObject lightGameObject = new GameObject("The Light");


        // Set the position (or any transform property)
        lightGameObject.transform.position = new Vector3(0f, hair.transform.position.y + .5f, 0f);
            
            // Add the light component
            Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.type = LightType.Directional;
        lightComp.color = Color.black;
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
