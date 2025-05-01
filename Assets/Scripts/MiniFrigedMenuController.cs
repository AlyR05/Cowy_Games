using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniFrigedMenuController : MonoBehaviour
{
    public TMP_Text staminaText;

    PlayerStats playerStats;
    private

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {

        staminaText.text = playerStats.stamina.ToString();
    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharecterMovements>().enabled = true;
    }

    public void TrainButton()
    {
        if (playerStats.timeLeft <= 0)
        {
            return;
        }

        //Increase player strength
        playerStats.stamina += 10;

        // Decrease player time by 1 hour
        playerStats.timeLeft--;

        // Update the strength text
        staminaText.text = playerStats.stamina.ToString();
    }
}
