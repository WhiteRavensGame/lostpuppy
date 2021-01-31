using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameManager GameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.gateKeyGot == (true))
        {
            gameObject.SetActive(false);
        }
    }
}
