using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GmoneyMgr : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    // Update is called once per frame
    void Update()
    {
        moneyText.text = "M : " + GameMgr.Instance.money;
    }
}
