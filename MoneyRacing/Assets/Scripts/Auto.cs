using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Auto : MonoBehaviour
{
    public GameObject preFab;
    private int time;
    private Vector3 RandomPos;
    void Start()
    {
        time = 0;
    }
    void Update()
    {
        if (GameMgr.Instance.levelUp == false && GameMgr.Instance.gameOver == false)
        {
            Random_Spawn();
            time = time + 1;
        }   
    }

    public void Random_Spawn()
    {
        int RandomX = UnityEngine.Random.Range(1, 199);
        int RandomZ = UnityEngine.Random.Range(1, 199);

        RandomPos = new Vector3(RandomX, 0.5f, RandomZ);

        if (time >= 100)
        {
            Instantiate(preFab, RandomPos, Quaternion.identity);
            time = 0;
        }
    }
}
