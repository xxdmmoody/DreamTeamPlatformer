using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtDistance : MonoBehaviour {
    public float distance = 100;
    bool playerStepped = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(transform.position, Camera.main.transform.position) > distance && playerStepped)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag.Equals("Player") )
        {
            Debug.Log("STEP!");
            playerStepped = true;
        }
        
    }
}
