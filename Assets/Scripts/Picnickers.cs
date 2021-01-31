using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Picnickers : MonoBehaviour
{
    public UIManager UIManager;
    public GameManager GameManager;

    public Text speakerName;
    public Text diaText;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        speakerName.text = "Picnickers";

        if (GameManager.breadCollected == (true) && GameManager.birdGot == (false))
        {
            diaText.text = "\"Thanks dude, good pup!\"";

            UIManager.InitiateDia();

            GameManager.picGot = (true);

            return;
        }
        
        diaText.text = "\"We lost one out of our peices of bread. We have some, but it's always nice to have more on hand, think you can find it?\"";

        UIManager.InitiateDia();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UIManager.DeactivateDia();
    }
}
