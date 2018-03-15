using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    private float timeLeft = 60f;
    public int score = 0;
    public int endScore = 0;
    public GameObject timeLeftUI;
    public GameObject scoreUI;
   

    void Update()
    {
        if (timeLeft >= 0.1f)
        {
            Debug.Log(timeLeft);
            timeLeft -= Time.deltaTime;
            timeLeftUI.gameObject.GetComponent<Text>().text = ("Time left: " + (int)timeLeft);
            scoreUI.gameObject.GetComponent<Text>().text = ("Score: " + score);
        }
        if (timeLeft < 0.1f)
        {
            endScore = score;
            PlayerPrefs.SetInt("endscore", endScore);
            SceneManager.LoadScene("ending");
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    { //collison with level end
        

    }
    
   
}
