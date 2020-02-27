using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag=="player")
        {
         score_sayma.score_art();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
