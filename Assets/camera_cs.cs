using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_cs : MonoBehaviour {
    GameObject go_bird;
	// Use this for initialization
	void Start () {
        //go_bird = GameObject.FindGameObjectsWithTag("bird");
	}
	void FixedUpdate()
    {
        transform.position += new Vector3(bird.forward*Time.deltaTime, 0, 0);
    }
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        float width = ((BoxCollider2D)coll).size.x;
        coll.transform.position += new Vector3(width * 10, 0, 0);
    }
}
