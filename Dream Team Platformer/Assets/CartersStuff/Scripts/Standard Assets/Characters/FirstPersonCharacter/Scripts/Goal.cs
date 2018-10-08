using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {

        if(collider.CompareTag("Player"))
            gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.red;    
    }
}
