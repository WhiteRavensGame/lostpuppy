using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Bear : MonoBehaviour
{
    public UIManager UIManager;
    public GameManager GameManager;

    public Text speakerName;
    public Text diaText;

    private bool doneOnce = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        speakerName.text = "Barry the Bear";

        if (GameManager.bearKeyGot == (true))
        {
            diaText.text = "\"Thank you, Kind doggo\"";

            UIManager.InitiateDia();

            if (doneOnce == false)
            {
                GameManager.Instance.goodDeeds++;

                doneOnce = true;
            }
            
            return;
        }

        diaText.text = "\"Please save me, I need the brown key to open this trap, or else I'll die...\"";

        UIManager.InitiateDia();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UIManager.DeactivateDia();
    }
}
