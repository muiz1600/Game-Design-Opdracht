using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    private float timeLeft = 60f;
    public int score = 0;
    public GameObject timeLeftUI;
    public GameObject scoreUI;

    void Update()
    {
        Debug.Log(timeLeft);
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time left: " + (int)timeLeft);
        scoreUI.gameObject.GetComponent<Text>().text = ("Score: " + score);
        if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene("prototype1"); //reset level
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    { //collison with level end
        if (trig.gameObject.name == "EndLevel")
        {
            CountScore();
        }
        if (trig.gameObject.tag == "Coin")
        {
            score = score + 50;
            Destroy(trig.gameObject);
        }

    }

    void CountScore()
    {
        score = score + (int)(timeLeft * 10);
        Debug.Log(score);
    }
}
