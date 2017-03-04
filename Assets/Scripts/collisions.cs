using UnityEngine;
using System.Collections;

public class collisions : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GlobalGameState state = GameObject.Find("GlobalState").GetComponent<GlobalGameState>();
        if (collision.gameObject.name.Equals("wave(Clone)")) {
            wave w = collision.gameObject.GetComponent<wave>();
            if (state.colorId != w.waveID)
            {
                GameObject.Find("Miss").GetComponent<AudioSource>().Play();
                state.hits++;
                if (state.hits == 1) {
                    GameObject.Find("lose4").GetComponent<RectTransform>().localScale = new Vector3(0.10463f, 0.10463f, 0.10463f);
                }
                else if (state.hits == 2) {
                    GameObject.Find("lose3").GetComponent<RectTransform>().localScale = new Vector3(0.10463f, 0.10463f, 0.10463f);
                }
                else if (state.hits == 3)
                {
                    GameObject.Find("lose2").GetComponent<RectTransform>().localScale = new Vector3(0.10463f, 0.10463f, 0.10463f);
                }
                else if (state.hits == 4)
                {
                    GameObject.Find("lose1").GetComponent<RectTransform>().localScale = new Vector3(0.10463f, 0.10463f, 0.10463f);
                }
            }
            else {
                state.score += 100 + (int)((10 * state.getSpeed()) / state.getSpawnTime());
            }
            Destroy(collision.gameObject);
            if (state.hits == 4) {
                state.gameOver = true;
                GameObject.Find("Sounds").GetComponent<AudioSource>().Pause();
                GameObject.Find("Boo").GetComponent<AudioSource>().Play();
                Invoke("gameOver", 0.1f);
            }
        }
    }

    void gameOver() {
        GameObject.Find("GameOverPanel").GetComponent<RectTransform>().localScale = Vector3.one;
        Time.timeScale = 0;
    }
}
