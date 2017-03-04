using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("changeScene", 17f);
	}

    public void changeScene() {
        SceneManager.LoadScene(0);
    }
}
