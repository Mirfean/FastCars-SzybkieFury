using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_wheel : MonoBehaviour
{
    [SerializeField] private Car car;
    [SerializeField] private float wheel_speed = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(car.GetSpeed() * wheel_speed, 0f, 0f), Space.Self);
    }
}
