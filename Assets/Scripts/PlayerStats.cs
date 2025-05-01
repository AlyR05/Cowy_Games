using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    

    public TMP_Text text;
    public string playerName = "Mirko";
    public int strength = 1;
    public int stamina = 1;
    public int health = 1;
    public int speed = 1;
    public int timeLeft = 4;
    // Start is called before the first frame update
    void Start()
    {
        MyFunction();
        strength++;

        if (strength > 100)

            Debug.Log("Foo");
        Debug.Log("Bar");

    }
      
    // Update is called once per frame
    void Update()
    {    
    }
    void MyFunction()
    {

        Debug.Log("pikmin");
        Debug.Log("yellow_pikmin gang");
        Debug.Log("blue pikmin gang");
    }
}
        
