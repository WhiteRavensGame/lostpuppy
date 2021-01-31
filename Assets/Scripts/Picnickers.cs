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
            diaText.text = "\"Tubular, doggie bruh!!  Yo, this is totally going on my myspace!\"";

            UIManager.InitiateDia();

            GameManager.picGot = (true);

            return;
        }
        
        diaText.text = "\"Suuup, doggie bruh! Yooo, you see any bread lying around? We got some, but just incase we need more, mind finding it?\"";

        UIManager.InitiateDia();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UIManager.DeactivateDia();
    }
}
