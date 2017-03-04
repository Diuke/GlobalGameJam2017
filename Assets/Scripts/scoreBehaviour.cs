using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreBehaviour : MonoBehaviour {
    private GameObject scorePanel;
    private GameObject congratsPanel;
    private GameObject imagen;
	// Use this for initialization
	void Start () {
        congratsPanel = GameObject.Find("congratulationsPanel");
        scorePanel = GameObject.Find("leaderBoard");
        //imagen = GameObject.Find("Images");
        scorePanel.GetComponent<RectTransform>().localScale = Vector3.zero;
        //imagen.GetComponent<RectTransform>().localScale = Vector3.zero;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) {
            SceneManager.LoadScene(0); 
        }
	}
}
