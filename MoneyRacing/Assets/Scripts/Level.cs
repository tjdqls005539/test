using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Level : MonoBehaviour
{
    void Start()
    {
        GameMgr.Instance.slider.maxValue = 5;
    }
    void Update()
    {
        LevelSystem();
    }

    public void LevelSystem()
    {
        if (GameMgr.Instance.score == GameMgr.Instance.slider.maxValue && GameMgr.Instance.levelUp == false)
        {
            GameMgr.Instance.level += 1;
            GameMgr.Instance.score = 0;
            GameMgr.Instance.slider.maxValue += 10;
            GameMgr.Instance.levelUp = true;
            Time.timeScale = 0;
        }
    }
    public void SpeedUp() 
    {
        if (GameMgr.Instance.levelUp == true)
        {
            GameMgr.Instance.speed += 5;
            GameMgr.Instance.levelUp = false;
            Time.timeScale = 1;
        }
    }
    public void ScaleUp()
    {
        if (GameMgr.Instance.levelUp == true)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x + 1, this.transform.localScale.y + 1, this.transform.localScale.z + 1);
            GameMgr.Instance.levelUp = false;
            Time.timeScale = 1;
        }
    }
}
