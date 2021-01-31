using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SadChild : MonoBehaviour
{
    public UIManager UIManager;
    public GameManager GameManager;

    public Text speakerName;
    public Text diaText;

    private bool doneOnce = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        speakerName.text = "Sad Child";

        if (GameManager.ballGot == (true))
        {
            diaText.text = "\"Thanks so much Mr. Dog!\"";

            UIManager.InitiateDia();

            if (doneOnce == false)
            {
                GameManager.Instance.goodDeeds++;

                doneOnce = true;
            }

            return;
        }

        diaText.text = "\"Really wish I didn't play by the water with my ball...\"";

        UIManager.InitiateDia();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UIManager.DeactivateDia();
    }
}
