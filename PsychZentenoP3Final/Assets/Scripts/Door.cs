using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door_closed, door_opened, intText, lockedtext;
    public AudioSource open, close;
    public bool opened, locked;
    public static bool keyfound;
    public GameObject timertxt, timerTextTwo;

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
                        door_closed.SetActive(false);
                        door_opened.SetActive(true);
                        timertxt.SetActive(false);
                        timerTextTwo.SetActive(true);
                        intText.SetActive(false);
                        //open.Play();
                        StartCoroutine(repeat());
                        opened = true;
                    }
                }
                if(locked == true)
                {
                    lockedtext.SetActive(true);
                    timertxt.SetActive(true);
                    timerTextTwo.SetActive(false);
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
        yield return new WaitForSeconds(4.0f);
        opened = false;
        door_closed.SetActive(true);
        door_opened.SetActive(false);
        //close.Play();
    }
}
