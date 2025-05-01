using TMPro;
using UnityEngine;

public class BedMenuController : MonoBehaviour
{
    public TMP_Text healthText;

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

        healthText.text = playerStats.timeLeft.ToString();

    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<CharecterMovements>().enabled = true;
    }

    public void TrainButton()
    {

        //Increase player strength
        playerStats.timeLeft = 8;

        // Update the strength text
        healthText.text = playerStats.timeLeft.ToString();
    }
}
