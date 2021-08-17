using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public enum winning_prize
{
    Bronze,
    Silver,
    Gold,
    Secret
}

public class Winning_Screen : MonoBehaviour
{
    [SerializeField] RawImage trophy;
    [SerializeField] TextMeshProUGUI text;

    public void Start()
    {
        //Get type of gate
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void GetWinningSign(winning_prize prize)
    {
        string temp = "You win a bronze puchar!/n To get better,/n choose harder/n route next time";
        switch (prize)
        {
            case winning_prize.Bronze:
                text.text = temp;
                break;
            case winning_prize.Silver:
                break;
            case winning_prize.Gold:
                break;
            case winning_prize.Secret:
                break;
        }
    }

}
