using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    [SerializeField] GameObject WinningSign;
    [SerializeField] Score score;
    [SerializeField] Car car;
    [SerializeField] float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WinningSign.SetActive(true);
            new WaitForSeconds(3);
            int final_score = (int)score.Score_value + (car.Health * 1000) - (int)((timer - 45) * 100);
            PlayerPrefs.SetInt("player_score", (int)score.Score_value + (car.Health*500));
            PlayerPrefs.SetFloat("timer", Time.time - timer);
            SceneManager.LoadScene("Win");
        }
    }
}
