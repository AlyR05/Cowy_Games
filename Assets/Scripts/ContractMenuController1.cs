using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContractMenuController : MonoBehaviour
{
    public TMP_Text firstStatText;

    public TMP_Text secondStatText;

    public TMP_Text thirdStatText;

    public GameObject winpopup;

    PlayerStats playerStats;

    public int firstStatGoal = 150;

    public int secondStatGoal = 100;

    public int thirdStatGoal = 50;

    public TMP_Text timeText;

    private PlayerStats playerstats;

    // Start is called before the first frame update
    void Start()
    {

        playerStats = FindAnyObjectByType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        firstStatText.text = playerStats.strength.ToString() + "/" + firstStatGoal.ToString();
        secondStatText.text = playerStats.stamina.ToString() + "/" + firstStatGoal.ToString();
        thirdStatText.text = playerStats.health.ToString() + "/" + firstStatGoal.ToString();
    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharecterMovements>().enabled = true;
    }

    public void SignButton()
    {
        if (playerStats.strength >= firstStatGoal
            && playerStats.stamina >= secondStatGoal
            && playerStats.health >= thirdStatGoal)
        {
            winpopup.SetActive(true);
        }
    }
}
