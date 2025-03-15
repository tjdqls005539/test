using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * GameMgr.Instance.speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * GameMgr.Instance.speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * GameMgr.Instance.speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * GameMgr.Instance.speed * Time.deltaTime);
        }
    }
}
