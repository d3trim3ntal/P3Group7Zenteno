using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabinet : MonoBehaviour
{
    public GameObject cabinet_closed, cabinet_opened, intText, lockedtext;
    public AudioSource open, close;
    public bool opened, locked;
    public static bool keyfound;

    // Start is called before the first frame update
    void Start()
    {
        keyfound = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyfound == true)
        {
            locked = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            if(opened == false)
            {
                if(locked == false)
                {
                    intText.SetActive(true);
                    if(Input.GetKeyDown(KeyCode.F))
                    {
                        cabinet_closed.SetActive(false);
                        cabinet_opened.SetActive(true);
                        intText.SetActive(false);
                        //open.Play();
                        StartCoroutine(repeat());
                        opened = true;
                    }
                }
                if(locked == true)
                {
                    lockedtext.SetActive(true);
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            lockedtext.SetActive(false);
        }
    }

    IEnumerator repeat()
    {
        yield return new WaitForSeconds(10.0f);
        opened = false;
        cabinet_closed.SetActive(true);
        cabinet_opened.SetActive(false);
        //close.Play();
    }
}
