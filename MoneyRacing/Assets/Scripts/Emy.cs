using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Emy : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent agent;
    public GameObject over;
    public GameObject time_B;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        agent.speed = 0;
    }
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        agent.speed = GameMgr.Instance.time/3;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            over.SetActive(true);
            time_B.SetActive(false);
            GameMgr.Instance.gameOver = true;
            Time.timeScale = 0;
        }
    }
}
