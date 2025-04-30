using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ContractMenuController : MonoBehaviour

{
    public TMP_Text firstStatText;

    public TMP_Text secondStatText;

    public TMP_Text thirdStatText;

    public GameObject winPopup;

    public int firstStatGoal = 200;

    public int secondStatGoal = 150;

    public int thirdStatGoal = 100;








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
        firstStatText.text = playerStats.strength.ToString() + "/" + firstStatGoal.ToString();
        secondStatText.text = playerStats.strength.ToString() + "/" + firstStatGoal.ToString();
        thirdStatText.text = playerStats.strength.ToString() + "/" + firstStatGoal.ToString();

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


    public void SignButton()
    {
        if (playerStats.strength >= firstStatGoal
            && playerStats.stamina >= secondStatGoal
            && playerStats.pace >= secondStatGoal)
        {
            winPopup.SetActive(true);
        }
    }
}
