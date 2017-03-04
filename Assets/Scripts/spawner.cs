using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
    public GameObject toClone;
    private GameObject cloneLeft;
    private GameObject cloneRight;
    private Vector3 spawnRight;
    private Vector3 spawnLeft;

    //Sprites
    private Color green;
    private Color purple;
    private Color yellow;
    private Color red;
    private Color blue;
    private Color orange;

    // Use this for initialization
    void Start () {
        green = new Color(0.11f, 0.91f, 0.18f);
        purple = new Color(0.4f, 0.05f, 0.5f);
        yellow = new Color(1,1,0.15f);
        red = Color.red;
        blue = Color.blue;
        orange = new Color(1f, 0.46f, 0f);
        spawnLeft = new Vector3(-890f, -190f, -70.178f);
        spawnRight = new Vector3(890f, -190f, -70.178f);
        StartCoroutine(spawnTimers());
    }
	
	// Update is called once per frame
	void Update () {
           
	}

    public IEnumerator spawnTimers() {
        while (true) {
            GlobalGameState state = GameObject.Find("GlobalState").GetComponent<GlobalGameState>();
            spawn();
            yield return new WaitForSeconds(state.getSpawnTime());
        }
    }

    void spawn() {
        int rand = (int)Random.Range(0, 6);
        GlobalGameState state = GameObject.Find("GlobalState").GetComponent<GlobalGameState>();
        cloneLeft = null;
        cloneRight = null;
        
        switch (rand){
            case 0: //purple
                cloneRight = Instantiate(toClone, spawnRight, Quaternion.identity) as GameObject;
                //cloneLeft.GetComponent<SpriteRenderer>().color = purple;
                cloneRight.GetComponent<SpriteRenderer>().color = purple;
                
                break;
            case 1: //yellow
                cloneLeft = Instantiate(toClone, spawnLeft, Quaternion.identity) as GameObject;
                cloneLeft.GetComponent<SpriteRenderer>().color = yellow;
                //cloneRight.GetComponent<SpriteRenderer>().color = yellow;
                break;
            case 2: //red
                cloneLeft = Instantiate(toClone, spawnLeft, Quaternion.identity) as GameObject;
                cloneLeft.GetComponent<SpriteRenderer>().color = red;
                //cloneRight.GetComponent<SpriteRenderer>().color = red;
                break;
            case 3: //blue
                cloneLeft = Instantiate(toClone, spawnLeft, Quaternion.identity) as GameObject;
                cloneLeft.GetComponent<SpriteRenderer>().color = blue;
                //cloneRight.GetComponent<SpriteRenderer>().color = blue;
                break;
            case 4: //green
                cloneRight = Instantiate(toClone, spawnRight, Quaternion.identity) as GameObject;
                //cloneLeft.GetComponent<SpriteRenderer>().color = green;
                cloneRight.GetComponent<SpriteRenderer>().color = green;
                break;
            case 5: //orange
                cloneRight = Instantiate(toClone, spawnRight, Quaternion.identity) as GameObject;
                //cloneLeft.GetComponent<SpriteRenderer>().color = orange;
                cloneRight.GetComponent<SpriteRenderer>().color = orange;
                break;
        }
        if (cloneLeft != null) {
            cloneLeft.AddComponent<waveMove>();
            cloneLeft.GetComponent<waveMove>().right = false;
            cloneLeft.GetComponent<waveMove>().speed = state.getSpeed();
            cloneLeft.transform.Rotate(0, 180, 0);
            cloneLeft.GetComponent<wave>().waveID = rand;
        }
        if (cloneRight != null) {
            cloneRight.AddComponent<waveMove>();
            cloneRight.GetComponent<waveMove>().right = true;
            cloneRight.GetComponent<waveMove>().speed = state.getSpeed();
            cloneRight.GetComponent<wave>().waveID = rand;
        }



    }
}
