using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePersistence : MonoBehaviour {
    public int score;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void setScore(int s) {
        score = s;
    }

    public int getScore() {
        return score;
    }
}
