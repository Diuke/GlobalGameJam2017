using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class environment : MonoBehaviour {
    private Color red;
    private Color purple;
    private Color green;
    private Color orange;
    private Color blue;
    private Color yellow;
    private Color redS;
    private Color purpleS;
    private Color greenS;
    private Color orangeS;
    private Color blueS;
    private Color yellowS;
    private float opacity;
    private string lastKey;
    private bool[] keysPressed;
    // Use this for initialization
    void Start () {
        keysPressed = new bool[6];
        opacity = 0.3f;
        green = new Color(0.3f, 0.75f, 0.15f, opacity+0.4f);
        purple = new Color(0.4f, 0.05f, 0.5f, opacity + 0.4f);
        yellow = Color.yellow;
        yellow.a = opacity + 0.4f;
        red = Color.red;
        red.a = opacity + 0.4f;
        blue = Color.blue;
        blue.a = opacity + 0.4f;
        orange = new Color(1f, 0.6f, 0.09f, opacity + 0.4f);

        opacity = 0.3f;
        greenS = new Color(0.3f, 0.75f, 0.15f, opacity);
        purpleS = new Color(0.4f, 0.05f, 0.5f, opacity);
        yellowS = Color.yellow;
        yellowS.a = opacity;
        redS = Color.red;
        redS.a = opacity;
        blueS = Color.blue;
        blueS.a = opacity;
        orangeS = new Color(1f, 0.6f, 0.09f, opacity+0.2f);

        GameObject objeto = null;
        for (int i = 0; i < 6; i++)
        {
            switch (i)
            {
                case 0:
                    objeto = GameObject.Find("lightRed");
                    break;
                case 1:
                    objeto = GameObject.Find("lightYellow");
                    break;
                case 2:
                    objeto = GameObject.Find("lightBlue");
                    break;
                case 3:
                    objeto = GameObject.Find("lightOrange");
                    break;
                case 4:
                    objeto = GameObject.Find("lightGreen");
                    break;
                case 5:
                    objeto = GameObject.Find("lightPurple");
                    break;
            }
            updateOpacity(GameObject.Find("lightMain").GetComponent<SpriteRenderer>(), new Color(0, 0, 0), false);
            updateOpacity(objeto.GetComponent<SpriteRenderer>(), new Color(0, 0, 0), false);
        }
        
	}

    // Update is called once per frame
    void Update()
    {
        GlobalGameState state = GameObject.Find("GlobalState").GetComponent<GlobalGameState>();
        Color updateColor = Color.white;

        //keypresses
        if (Input.GetKeyDown("a")) {
            lastKey = "a";
            keysPressed[0] = true;
        }
        else if (Input.GetKeyDown("s")) {
            lastKey = "s";
            keysPressed[1] = true;
        }
        else if (Input.GetKeyDown("d")){
            lastKey = "d";
            keysPressed[2] = true;
        }
        else if (Input.GetKeyDown("j")){
            lastKey = "j";
            keysPressed[3] = true;
        }
        else if (Input.GetKeyDown("k")){
            lastKey = "k";
            keysPressed[4] = true;
        }
        else if (Input.GetKeyDown("l")){
            lastKey = "l";
            keysPressed[5] = true;
        }
        //key ups
        if (Input.GetKeyUp("a"))
        {
            keysPressed[0] = false;
        }
        else if (Input.GetKeyUp("s"))
        {
            keysPressed[1] = false;
        }
        else if (Input.GetKeyUp("d"))
        {
            keysPressed[2] = false;
        }
        else if (Input.GetKeyUp("j"))
        {
            keysPressed[3] = false;
        }
        else if (Input.GetKeyUp("k"))
        {
            keysPressed[4] = false;
        }
        else if (Input.GetKeyUp("l"))
        {
            keysPressed[5] = false;
        }

        if (!Input.anyKey) {
            lastKey = " ";
        }

        updateOpacity(GameObject.Find("lightMain").GetComponent<SpriteRenderer>(), updateColor, false);
        updateOpacity(GameObject.Find("lightRed").GetComponent<SpriteRenderer>(), updateColor, false);
        updateOpacity(GameObject.Find("lightYellow").GetComponent<SpriteRenderer>(), updateColor, false); 
        updateOpacity(GameObject.Find("lightBlue").GetComponent<SpriteRenderer>(), updateColor, false);
        updateOpacity(GameObject.Find("lightGreen").GetComponent<SpriteRenderer>(), updateColor, false);
        updateOpacity(GameObject.Find("lightOrange").GetComponent<SpriteRenderer>(), updateColor, false);
        updateOpacity(GameObject.Find("lightPurple").GetComponent<SpriteRenderer>(), updateColor, false);

        switch (lastKey) {
            case "a":
                if (keysPressed[0] == true)
                {
                    updateColor = red;
                    updateOpacity(GameObject.Find("lightRed").GetComponent<SpriteRenderer>(), updateColor, true);
                    updateOpacity(GameObject.Find("lightMain").GetComponent<SpriteRenderer>(), redS, true);
                    state.colorId = 2;
                }
                break;
            case "s":
                if (keysPressed[1] == true)
                {
                    updateColor = yellow;
                    updateOpacity(GameObject.Find("lightYellow").GetComponent<SpriteRenderer>(), updateColor, true);
                    updateOpacity(GameObject.Find("lightMain").GetComponent<SpriteRenderer>(), yellowS, true);
                    state.colorId = 1;
                }
                break;
            case "d":
                if (keysPressed[2] == true)
                {
                    updateColor = blue;
                    updateOpacity(GameObject.Find("lightBlue").GetComponent<SpriteRenderer>(), updateColor, true);
                    updateOpacity(GameObject.Find("lightMain").GetComponent<SpriteRenderer>(), blueS, true);
                    state.colorId = 3;
                }
                break;
            case "j":
                if (keysPressed[3] == true)
                {
                    updateColor = green;
                    updateOpacity(GameObject.Find("lightGreen").GetComponent<SpriteRenderer>(), updateColor, true);
                    updateOpacity(GameObject.Find("lightMain").GetComponent<SpriteRenderer>(), greenS, true);
                    state.colorId = 4;
                }
                break;
            case "k":
                if (keysPressed[4] == true)
                {
                    updateColor = orange;
                    updateOpacity(GameObject.Find("lightOrange").GetComponent<SpriteRenderer>(), updateColor, true);
                    updateOpacity(GameObject.Find("lightMain").GetComponent<SpriteRenderer>(), orangeS, true);
                    state.colorId = 5;
                }
                break;
            case "l":
                if (keysPressed[5] == true)
                {
                    updateColor = purple;
                    updateOpacity(GameObject.Find("lightPurple").GetComponent<SpriteRenderer>(), updateColor, true);
                    updateOpacity(GameObject.Find("lightMain").GetComponent<SpriteRenderer>(), purpleS, true);
                    state.colorId = 0;
                }
                break;
            case " ":
                state.colorId = 6;
                break;
        }
    }

    void updateOpacity(SpriteRenderer spotlight, Color inheritedColor, bool makeVisible) {
        if (!makeVisible)
        {
            inheritedColor.a = 0;
            spotlight.color = inheritedColor;
        }
        else
        {
            spotlight.color = inheritedColor; 
        }
        
    }
}
