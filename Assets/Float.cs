using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject seaCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.floatGot = (true);

        gameObject.SetActive(false);
        seaCollider.SetActive(false);
    }
}
