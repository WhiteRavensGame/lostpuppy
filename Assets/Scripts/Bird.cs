using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public UIManager UIManager;
    public GameManager GameManager;

    public Text speakerName;
    public Text diaText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        speakerName.text = "Floc the Green Bird";

        if (GameManager.breadCollected == (true) && GameManager.picGot == (false))
        {
            diaText.text = "\"*squeek* Thank you so much! *squeek*\"";

            UIManager.InitiateDia();

            GameManager.birdGot = (true);

            return;
        }
        
        diaText.text = "\"*squeek* Have you seen a peice of bread somewhere? I need to feed my hatchlings but I can't leave my nest *squeek*\"";

        UIManager.InitiateDia();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UIManager.DeactivateDia();
    }
}
