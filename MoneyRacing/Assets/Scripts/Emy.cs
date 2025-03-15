using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Emy : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
