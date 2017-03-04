using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GlobalGameState : MonoBehaviour {

    public int hits;
    public bool gameOver;
    public int colorId;
    public int time;
    private int level;
    private float speed;
    private float pace;
    private float spawnTime;
    private float defaultSpeed;
    private int timePace;
    private float spawnPace;
    public int score;

    public float getSpeed() {
        return speed;
    }

    public float getSpawnTime() {
        return spawnTime;
    }

	void Start () {
        score = 0;
        level = 0;
        speed = 3f;
        pace = 0.25f;
        timePace = 10;
        defaultSpeed = 3f;
        spawnTime = 1.6f;
        spawnPace = 0.26f;
        gameOver = false;
	}

    void Update() {
        time = (int)Time.timeSinceLevelLoad;
        if (time <= 40)
        {
            if (time == timePace)
            {
                speed += pace;
                timePace += 10;
                spawnTime -= spawnPace;
            }
        }
        else {
            speed = 4;
            spawnTime = 0.85f;
        }
        
        GameObject.Find("Score").GetComponent<Text>().text = ""+score;
    }
}
