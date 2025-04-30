using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BedMenuController : MonoBehaviour
{
    public TMP_Text restText;
    private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
       playerStats = FindAnyObjectByType<PlayerStats>();
       restText.text = playerStats.rest.ToString();
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
        playerStats.rest += 10;

        // Decrease time by 1 hour
        playerStats.timeLeft--;

        // Update the strenght text
        restText.text = playerStats.rest.ToString();

    }
}
