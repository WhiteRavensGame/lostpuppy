using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearKey : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.bearKeyGot = (true);

        gameObject.SetActive(false);
    }
}
