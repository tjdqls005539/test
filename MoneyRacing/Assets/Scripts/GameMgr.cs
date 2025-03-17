using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    private static GameMgr instance;

    public static GameMgr Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameMgr();
            }
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    public int score = 0;
    public int level = 1;
    public int speed = 5;
    public Slider slider;
    public bool levelUp = false;
    public bool gameOver = false;
    public int money = 0;
    public float time = 0;

    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        score = 0;
        level = 1;
        speed = 5;
        levelUp = false;
        gameOver = false;
        money = 0;
        time = 0;
    }
}