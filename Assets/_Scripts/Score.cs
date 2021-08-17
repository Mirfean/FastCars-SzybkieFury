using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private float score_value;
    public float Score_value
    {
        get
        {
            return score_value;
        }
        set
        {
            score_value = value;
        }
    }

    [SerializeField] private Car car;


    // Start is called before the first frame update
    void Start()
    {
        Score_value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Score_value += car.GetSpeed() * Time.deltaTime;
        this.gameObject.GetComponent<TextMeshProUGUI>().text = ((int)Score_value).ToString();
    }
}
