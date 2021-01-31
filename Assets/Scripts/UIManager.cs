using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject diaBox;

    public void InitiateDia()
    {
        diaBox.SetActive(true);
    }

    public void DeactivateDia()
    {
        diaBox.SetActive(false);
    }
}
