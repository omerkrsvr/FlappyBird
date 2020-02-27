using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
    public float gravity;
    Vector3 bird_move = Vector3.zero;
    public Vector3 ucma_hizi;
    bool bool_flapping;
    float max_speed=4f;
    public float speed_forward;
    public static float forward;
    Animator anim;
    bool death;
    float time = 1f;


	// Use this for initialization
	void Start () {
        forward = speed_forward;
        anim = transform.GetComponent<Animator>();
        death = false;
	}

    void FixedUpdate()
    {
        bird_move += new Vector3(0, -gravity, 0);
        float rot = 0;
        if (!death)
        {
            if (bool_flapping == true)
            {
                bool_flapping = false;
                bird_move += ucma_hizi;
            }
            if (bird_move.y > max_speed)
            {
                bird_move = new Vector3(bird_move.x, max_speed, bird_move.z);
            }
            bird_move = new Vector3(speed_forward, bird_move.y, bird_move.z);
            


            rot = Mathf.Lerp(0, -90, -bird_move.y / max_speed);

        }
        else
        {
            time = time - Time.deltaTime;
            
        }
        if(time<=0)
        {
            Application.LoadLevel("1");
        }
            transform.rotation = Quaternion.Euler(0, 0, rot);
            transform.position += bird_move * Time.deltaTime;
       
    }
	
	// Update is called once per frame
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.transform.tag=="yer"||coll.transform.tag=="engel")
        {
            death = true;
            anim.Play("dead");
            time = 1f;
            forward = 0;
            speed_forward = 0;
            bird_move = new Vector3(0, bird_move.y, bird_move.z);
        }
    }
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bool_flapping = true;
        }
		
	}
}
