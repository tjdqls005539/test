using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject obj;
    // Update is called once per frame
    void Update()
    {
        Skill();
    }

    public void Skill()
    {
        if (GameMgr.Instance.levelUp)
        {
            obj.SetActive(true);
        }
        else
        {
            obj.SetActive(false);
        }
    }
}
