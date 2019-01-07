using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour {
    public float startTimer = 0f;
    public float waitTime = 173f;
    public int tl = 1;
    public GameObject Controller;
    public GameObject[] Powers;
    Vector3 v1;
    Vector3 v2;
    Vector3 v3;
    Vector3 v4;
    Vector3 v5;
    public GameObject hair2;
    public GameObject hair3;
    // Use this for initialization
    void Start () {
         v1 = new Vector3(Controller.transform.position.x,
                 Controller.transform.position.y,
                 Controller.transform.position.z);
        v2 = new Vector3(Controller.transform.position.x,
                 Controller.transform.position.y + 1.5f,
                 Controller.transform.position.z);
        v5 = new Vector3(Controller.transform.position.x,
         Controller.transform.position.y + 1.5f,
         Controller.transform.position.z + .07f);
        v3 = new Vector3(Controller.transform.position.x,
         Controller.transform.position.y + 1f,
         Controller.transform.position.z);
        v4 = new Vector3(Controller.transform.position.x,
 Controller.transform.position.y - 1f,
 Controller.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // Timer
        startTimer += Time.deltaTime;
        if (tl == 1)
        {
            Instantiate(Powers[0], v1, Quaternion.identity);
            tl += 1;
        }
        if (startTimer >= 7 && tl == 2)
        {
            Instantiate(hair2, v2, Quaternion.identity);
            tl += 1;
        }
        if (startTimer >= 51.5 && tl == 3)
        {
            Instantiate(Powers[2], v3, Quaternion.identity);
            tl += 1;
        }
        if (startTimer >= 79 && tl == 4)
        {
            Instantiate(Powers[3], v4, Quaternion.identity);
            tl += 1;
        }
        if (startTimer >= 84 && tl == 5)
        {
            Instantiate(Powers[1], v1, Quaternion.identity);
            tl += 1;
        }
        if (startTimer >= 134.5 && tl == 6)
        {
            Instantiate(Powers[1], v1, Quaternion.identity);
            tl += 1;
        }
        if (startTimer >= 135.5 && tl == 7)
        {
            Instantiate(Powers[1], v1, Quaternion.identity);
            tl += 1;
        }
        if (startTimer >= 159.5 && tl == 8)
        {
            Instantiate(hair3, v5, Quaternion.identity);
            tl += 1;
        }
        if (startTimer > waitTime)
        {
            Destroy(gameObject);
        }
    }
}
