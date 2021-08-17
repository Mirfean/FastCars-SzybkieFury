using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField] private GameObject flag;
    [SerializeField] private GameObject CheckpointParent;
    // Start is called before the first frame update
    void Start()
    {
        flag.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CheckpointParent.transform.childCount);
        if(CheckpointParent.transform.childCount == 0)
        {
            flag.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
