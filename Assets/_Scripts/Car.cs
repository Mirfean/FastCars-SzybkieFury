using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    [SerializeField] private float accelerationPerSecond = 0.2f;
    [SerializeField] private float turnSpeed = 200f;
    [SerializeField] HealthBar healthBar;
    [SerializeField] private float speedSoftCap = 20;
    [SerializeField] private float speedHardCap = 40;
    [SerializeField] private Score score;

    private int health = 3;
    public int Health
    {
        get { return this.health; }
        set 
        { 
            this.health = value;
            healthBar.ChangeHealthText(Health);
        }
    }

    private int steerValue;
    public int SteerValue
    {
        get { return this.steerValue; }
        set { this.steerValue = value; }
    }

    public float GetSpeed()
    {
        return speed;
    }

    void Start()
    {
        Health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedUp();
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground" && collision.gameObject.tag != "Cone" && speed > 10)
        {
            speed = 0;
            Health -= 1;
            CheckHealth();
            this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, -600), ForceMode.Impulse);
        }
        if (collision.gameObject.tag == "Cone")
        {
            score.Score_value += 1000 * Time.deltaTime;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("MainMenu");
        }
        else if(other.CompareTag("Win"))
        {
            
        }
    }

    private void SpeedUp()
    {
        float accelerationMod = 1f;
        if(speed < speedSoftCap)
        {
            accelerationMod = 5;
        }
        else if(speed > accelerationMod)
        {
            accelerationMod = 0.2f;
        }
        speed += accelerationPerSecond * accelerationMod * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }

    private void CheckHealth()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }


}
