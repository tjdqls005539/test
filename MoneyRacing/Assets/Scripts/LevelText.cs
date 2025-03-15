using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelText : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Update is called once per frame
    void Update()
    {
        text.text = "LEVEL: " + GameMgr.Instance.level;
    }
}
