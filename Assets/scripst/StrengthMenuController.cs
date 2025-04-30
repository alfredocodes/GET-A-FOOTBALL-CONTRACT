using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StrengthMenuController : MonoBehaviour
{
    public TMP_Text paceText;
    private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
       playerStats = FindAnyObjectByType<PlayerStats>();
       paceText.text = playerStats.pace.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitMenu()
    {
        gameObject.SetActive(false);
        FindAnyObjectByType<MovementCharacter>().enabled = true;

    }

    public void TrainButton()
    {
       

        // Increase player pace
        playerStats.pace += 10;

        // Decrease time by 1 hour
        playerStats.timeLeft--;

        // Update the strenght text
        paceText.text = playerStats.pace.ToString();

    }
}
