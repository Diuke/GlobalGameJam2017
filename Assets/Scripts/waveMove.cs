using UnityEngine;
using System.Collections;

public class waveMove : MonoBehaviour
{
    public float speed;
    public bool right;
    private GlobalGameState status;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        status = GameObject.Find("GlobalState").GetComponent<GlobalGameState>();
        if (status.gameOver == false) {
            if (right)
            {
                transform.position -= new Vector3(speed, 0, 0);
            }
            else
            {
                transform.position += new Vector3(speed, 0, 0);
            }
        }
    }
}
