using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject inticon, key;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                key.SetActive(false);
                Door.keyfound = true;
                inticon.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
        }
    }
}
