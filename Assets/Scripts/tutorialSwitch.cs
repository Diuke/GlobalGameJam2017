using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialSwitch : MonoBehaviour {

    GameObject screen1;
    GameObject screen2;
    GameObject screen3;
    GameObject screen4;
    GameObject screen5;
    GameObject screen6;
    GameObject screen7;
    bool isScreenOne=true, isScreenTwo=false, isScreenThree=false, isScreenFour=false, isScreenFive = false, isScreenSix = false, isScreenSeven = false;
    // Use this for initialization
    void Start () {
        screen1 = GameObject.Find("TUT1");
        screen2 = GameObject.Find("TUT2");
        screen3 = GameObject.Find("TUT3");
        screen4 = GameObject.Find("TUT4");
        screen5 = GameObject.Find("TUT5");
        screen6 = GameObject.Find("TUT6");
        screen7 = GameObject.Find("TUT7");
        isScreenOne = true;
        isScreenTwo = false;
        isScreenThree = false;
        isScreenFour = false;
        isScreenFive = false;
        isScreenSix = false;
        isScreenSeven = false;
        screen1.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
        screen2.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
        screen3.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
        screen4.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
        screen5.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
        screen6.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
        screen7.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            if (isScreenOne)
            {
                isScreenOne = false;
                isScreenTwo = true;
                isScreenThree = false;
                isScreenFour = false;
                isScreenFive = false;
                isScreenSix = false;
                isScreenSeven = false;
                screen1.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen2.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
                screen3.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen4.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen5.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen6.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen7.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            }
            else if (isScreenTwo)
            {
                isScreenOne = false;
                isScreenTwo = false;
                isScreenThree = true;
                isScreenFour = false;
                isScreenFive = false;
                isScreenSix = false;
                isScreenSeven = false;
                screen1.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen2.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen3.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
                screen4.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen5.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen6.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen7.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            }
            else if (isScreenThree)
            {
                isScreenOne = false;
                isScreenTwo = false;
                isScreenThree = false;
                isScreenFour = true;
                isScreenFive = false;
                isScreenSix = false;
                isScreenSeven = false;
                screen1.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen2.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen3.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen4.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
                screen5.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen6.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen7.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            }
            else if (isScreenFour)
            {
                isScreenOne = false;
                isScreenTwo = false;
                isScreenThree = false;
                isScreenFour = false;
                isScreenFive = true;
                isScreenSix = false;
                isScreenSeven = false;
                screen1.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen2.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen3.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen4.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen5.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
                screen6.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen7.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            }
            else if (isScreenFive)
            {
                isScreenOne = false;
                isScreenTwo = false;
                isScreenThree = false;
                isScreenFour = false;
                isScreenFive = false;
                isScreenSix = true;
                isScreenSeven = false;
                screen1.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen2.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen3.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen4.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen5.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen6.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
                screen7.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            }
            else if (isScreenSix)
            {
                isScreenOne = false;
                isScreenTwo = false;
                isScreenThree = false;
                isScreenFour = false;
                isScreenFive = false;
                isScreenSix = false;
                isScreenSeven = true;
                screen1.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen2.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen3.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen4.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen5.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen6.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                screen7.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
            }
            else if (isScreenSeven)
            {
                SceneManager.LoadScene(0);
            }
        }

		
	}
}
