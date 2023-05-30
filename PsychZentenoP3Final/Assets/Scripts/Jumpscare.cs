using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public AudioSource scream;
    public GameObject thePlayer;
    public GameObject jumpCam;
    public GameObject flashImg;

    void OnTriggerEnter()
    {
        scream.Play();
        jumpCam.SetActive(true);
        thePlayer.SetActive(false);
        flashImg.SetActive(true);
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(8.0f);
        thePlayer.SetActive(true);
        jumpCam.SetActive(false);
        flashImg.SetActive(false);
    }
}
