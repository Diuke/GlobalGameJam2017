using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class clickEvent : MonoBehaviour, IPointerClickHandler {

    private InputField nameWriter;
    private string playerScore;
    private const string SCORE_KEY = "playerScore";
    int[] score = new int[4];
    int pos = 0;
    string thePlayer;
    string[] scoreboards;


    public void Start() {
        //scoreboards = new string[5];
        //PlayerPrefs.SetString("One", "Avicii:20000");
        //PlayerPrefs.SetString("Two", "Skrillex:15000");
        //PlayerPrefs.SetString("Three", "Tiesto:10000");
        //PlayerPrefs.SetString("Four", "Guetta:5000");
        //scoreboards[0] = PlayerPrefs.GetString("One");
        //scoreboards[1] = PlayerPrefs.GetString("Two");
        //scoreboards[2] = PlayerPrefs.GetString("Three");
        //scoreboards[3] = PlayerPrefs.GetString("Four");
        if (PlayerPrefs.GetInt("firstTime") == 0)
        {
            PlayerPrefs.SetString("One", "Avicii:20000");
            PlayerPrefs.SetString("Two", "Skrillex:15000");
            PlayerPrefs.SetString("Three", "Tiesto:10000");
            PlayerPrefs.SetString("Four", "Guetta:5000");
            scoreboards[0] = PlayerPrefs.GetString("One");
            scoreboards[1] = PlayerPrefs.GetString("Two");
            scoreboards[2] = PlayerPrefs.GetString("Three");
            scoreboards[3] = PlayerPrefs.GetString("Four");
        }
        else
        {
            scoreboards[0] = PlayerPrefs.GetString("One");
            scoreboards[1] = PlayerPrefs.GetString("Two");
            scoreboards[2] = PlayerPrefs.GetString("Three");
            scoreboards[3] = PlayerPrefs.GetString("Four");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        string playerName = GameObject.Find("playerName").GetComponent<InputField>().text;
        if (playerName.Equals("") || playerName.Length == 0)
        {
            Debug.Log("write");
        }
        else
        {
            GameObject.Find("congratulationsPanel").GetComponent<RectTransform>().localScale = Vector3.zero;
            //Poniendo visible los demas objetos
            //GameObject.Find("Images").GetComponent<RectTransform>().localScale = Vector3.one;
            GameObject.Find("leaderBoard").GetComponent<RectTransform>().localScale = Vector3.one;
            playerScore = ""+GameObject.Find("ScoreObject").GetComponent<ScorePersistence>().getScore();
            thePlayer = playerName;
            fromFilesToScoreboard();
        }
    }

    public void overridintTheLabels()
    {
        GameObject.Find("firstP").GetComponent<Text>().text = scoreboards[0].Split(':')[0];
        GameObject.Find("firstS").GetComponent<Text>().text = scoreboards[0].Split(':')[1];
        GameObject.Find("secondP").GetComponent<Text>().text = scoreboards[1].Split(':')[0];
        GameObject.Find("secondS").GetComponent<Text>().text = scoreboards[1].Split(':')[1];
        GameObject.Find("thirdP").GetComponent<Text>().text = scoreboards[2].Split(':')[0];
        GameObject.Find("thirdS").GetComponent<Text>().text = scoreboards[2].Split(':')[1];
        GameObject.Find("fourthP").GetComponent<Text>().text = scoreboards[3].Split(':')[0];
        GameObject.Find("fourthS").GetComponent<Text>().text = scoreboards[3].Split(':')[1];

        PlayerPrefs.SetString("One", scoreboards[0]);
        PlayerPrefs.SetString("Two", scoreboards[1]);
        PlayerPrefs.SetString("Three", scoreboards[2]);
        PlayerPrefs.SetString("Four", scoreboards[3]);
    }
    
    public void fromFilesToScoreboard() {
        scoreboards[4] = thePlayer + ":" + playerScore;
        for (int i = 0; i < 5; i++) {
            int pivot = i;
            for (int j = i + 1; j < 5; j++) {
                if (Convert.ToInt32(scoreboards[j].Split(':')[1]) > Convert.ToInt32(scoreboards[pivot].Split(':')[1])) { 
                    pivot = j;
                }
                string temp = scoreboards[i];
                scoreboards[i] = scoreboards[pivot];
                scoreboards[pivot] = temp;
            }
        }
        overridintTheLabels();
    }
    
}
