using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Time_s : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Update()
    {
        GameMgr.Instance.time = GameMgr.Instance.time + Time.deltaTime;
        text.text = string.Format("Time : {0:N0}", GameMgr.Instance.time);
    }
}
