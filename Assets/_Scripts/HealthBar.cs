using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ChangeHealthText();
    }

    public void ChangeHealthText(int health)
    {
        this.gameObject.GetComponent<TextMeshProUGUI>().text = health.ToString();
    } 


}
