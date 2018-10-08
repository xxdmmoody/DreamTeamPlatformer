using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class startGame : MonoBehaviour {

    public void GotoMainScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void changeBackground() {
        Image img = GameObject.Find("BackGround1").GetComponent<Image>();
        img = GameObject.Find("BackGround2").GetComponent<Image>();
    }
    
}
