using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScore : MonoBehaviour
{
    [SerializeField] private GameObject score_value;
    [SerializeField] private GameObject time_value;
    // Start is called before the first frame update
    void Start()
    {
        score_value.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("player_score").ToString();
        time_value.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("timer").ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
