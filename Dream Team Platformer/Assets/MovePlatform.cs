using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {
    public float speed = 25f;
    public float direction = -1f;
    Transform origPosition; 

    // Use this for initialization
    void Start () {
        origPosition = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(transform.position.x);
        transform.position -= new Vector3(direction * speed * .1f * Time.deltaTime,0, 0 );
        if (transform.position.x >= 5.0f)
        {
            direction = 1;
        }
        if (transform.position.x <= -5.0f)
        {
            direction = -1;
        }
    }
}
