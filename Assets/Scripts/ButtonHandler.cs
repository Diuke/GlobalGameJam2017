using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {

    public void changeScene(int scene) {
        Time.timeScale = 1;
        SceneManager.LoadScene(scene);
    }

    public void goToLeaderBoard() {
        Debug.Log(""+ GameObject.Find("GlobalState").GetComponent<GlobalGameState>().score);
        GameObject.Find("ScoreObject").GetComponent<ScorePersistence>().setScore(GameObject.Find("GlobalState").GetComponent<GlobalGameState>().score);
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void close(){
        Application.Quit();
        Debug.Log("Asdfa");
    }

    public void goToGame() {
        GameObject.Find("soundLoading").GetComponent<AudioSource>().Play();
        GameObject.Find("Loading").GetComponent<RectTransform>().localScale = Vector3.one;
        Time.timeScale = 1;
        GameObject.Find("Sound").GetComponent<AudioSource>().Pause();
        Invoke("openGame", 6f);
    }

    public void openGame() {
        GameObject.Find("soundLoading").GetComponent<AudioSource>().Pause();
        SceneManager.LoadScene(1);
    }

}
