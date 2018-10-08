using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour {
    public float distanceToInstantiate = 100;
    public GameObject basePlatform;
    public GameObject obstacle;

    // Use this for initialization
    void Start()
    {
       /* Vector3 currentPosition = Vector3.zero;
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        for (int i = 0; i < 10; i++)
        {
            Instantiate(basePlatform, currentPosition, rotation, gameObject.transform);
            currentPosition += new Vector3(0, 0, 12f);
        }*/
    }
    Vector3 currentPosition = Vector3.zero;
    Vector3 currentPosition2 = Vector3.zero;
    int x, y, z;
    Quaternion rotation = Quaternion.Euler(0, 0, 0);
    // Update is called once per frame
    void Update () {
        if (Vector3.Distance(Camera.main.transform.position, currentPosition) < distanceToInstantiate)
        {
            Input.GetAxis("Fire1");
            Instantiate(basePlatform, currentPosition, rotation, gameObject.transform);
            x = Random.Range(-2, 3);
            y = Random.Range(-1, 2);
            z = 12;
            currentPosition += new Vector3(x, y, z);
            currentPosition2 += new Vector3(x, y, z);
            Instantiate(obstacle, currentPosition2 + new Vector3(Random.Range(-1, 1), Random.Range(1, 2), 12), rotation, gameObject.transform);
           // currentPosition2 += new Vector3(Random.Range(-2, 3), Random.Range(-1, 2), 12f);
        }
    }
}
