using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {

    // Movement speed
    public float speed = 2;
    public float force = 300;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        // Restart
        Application.LoadLevel(Application.loadedLevel);
    }
    // Update is called once per frame
    void Update () {

        // Flap
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);


    }
}
