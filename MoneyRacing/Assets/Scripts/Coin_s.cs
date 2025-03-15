using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_s : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameMgr.Instance.score += 1;
            GameMgr.Instance.money += 1;
            Destroy(this.gameObject);
        }
    }
}
