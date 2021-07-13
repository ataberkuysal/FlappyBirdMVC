using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{

    [SerializeField]
    public Text score1;
    [SerializeField]
    public Text score2;
    
    public GameObject gameOverScreen;

    float lastTime;
    public static int score = 0;

    private void Awake()
    {
        lastTime = Time.time;
    }
    void Update()
    {
        score1.text = score.ToString();
        score2.text = score.ToString();
        
        if (BirdController.reloadIsTrue)
        {
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) && Time.time - lastTime > 1.5f)
            {
                BirdController.reloadIsTrue = false;
                gameOverScreen.SetActive(false);
                score=0;
                SceneManager.LoadScene(0);
            }
        }
    }
}
