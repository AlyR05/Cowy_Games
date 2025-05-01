using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComputerMenuController : MonoBehaviour
{
    public TMP_Text strengthText;

        PlayerStats playerStats ;
    private

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        strengthText.text = playerStats.strength.ToString();
    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharecterMovements>().enabled = true;
    }

    public void TrainButton()
    {
        if (playerStats.timeLeft <=0)
        {
            return;
        }

        //Increase player strength
        playerStats.strength += 10;

        // Decrease player time by 1 hour
        playerStats.timeLeft--;

        // Update the strength text
        strengthText.text = playerStats.strength.ToString();
    }
}
