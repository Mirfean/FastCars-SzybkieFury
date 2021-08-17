using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stozek : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Ground")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(-collision.contacts[0].normal + new Vector3(Random.Range(-0.5f, 0.5f), 0, Random.Range(-0.5f, 0.5f)));
        }
        
    }

}
