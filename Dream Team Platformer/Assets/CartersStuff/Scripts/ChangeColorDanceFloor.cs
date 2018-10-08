using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorDanceFloor : MonoBehaviour {

    float startTime;
    float elapsedTime;
    float time;
    public float timeToCompletePuzzle;
    public Material greyDanceFloor;
    public GameObject ChangeMyColor;
    public GameObject[] Patterns;
    public GameObject[] NOTpatterns;
    
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        elapsedTime = Time.time - startTime;
        //time = Time.timeSinceLevelLoad;

        if (elapsedTime >= 20f)
        {
            gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            elapsedTime = 0;

        }

        if ((Patterns[0].GetComponent<MeshRenderer>().materials[0].color == Color.green &&
            Patterns[1].GetComponent<MeshRenderer>().materials[0].color == Color.green &&
            Patterns[2].GetComponent<MeshRenderer>().materials[0].color == Color.green &&
            Patterns[3].GetComponent<MeshRenderer>().materials[0].color == Color.green &&
            Patterns[4].GetComponent<MeshRenderer>().materials[0].color == Color.green &&
            Patterns[5].GetComponent<MeshRenderer>().materials[0].color == Color.green &&
            Patterns[6].GetComponent<MeshRenderer>().materials[0].color == Color.green &&
            Patterns[7].GetComponent<MeshRenderer>().materials[0].color == Color.green &&
            Patterns[8].GetComponent<MeshRenderer>().materials[0].color == Color.green) &&
            (NOTpatterns[0].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[1].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[2].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[3].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[4].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[5].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[6].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[7].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[8].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[9].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[10].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[11].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[12].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[13].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[14].GetComponent<MeshRenderer>().materials[0].color == Color.gray &&
            NOTpatterns[15].GetComponent<MeshRenderer>().materials[0].color == Color.gray
            )  )
        
        {
            ChangeMyColor.GetComponent<MeshRenderer>().materials[0].color = Color.green;
        }


    }
    void OnTriggerEnter(Collider collider)
    {

        if (collider.CompareTag("Player") && gameObject.GetComponent<MeshRenderer>().materials[0].color != Color.green)
        {
            gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.green;
            startTime = Time.time;
        }
    }

}
