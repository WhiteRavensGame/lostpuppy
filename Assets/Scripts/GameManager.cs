using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool breadCollected = false;
    //public PauseMenu pauseMenu;
    public bool birdGot = false;
    public bool picGot = false;

    public bool bearKeyGot = false;
    public bool gateKeyGot = false;

    public bool floatGot = false;
    public bool ballGot = false;

    public int goodDeeds = 0;

    public static GameManager Instance;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }

    /*private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.Pause();
        }
    }*/
}
