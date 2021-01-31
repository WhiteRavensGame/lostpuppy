using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Script5 : MonoBehaviour
{
    public GameManager GameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.Instance.goodDeeds >= 2)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GoodEnding");
        }

        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("BadEnding");
        }
    }
}
