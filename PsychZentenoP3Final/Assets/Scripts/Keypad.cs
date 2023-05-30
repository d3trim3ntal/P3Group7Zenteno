using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;

    public GameObject animateOB;
    public Animator ANI;

    public TextMeshProUGUI textOB;
    public string answer = "9743";

    public AudioSource button;
    public AudioSource correct;
    public AudioSource wrong;

    public bool animate;

    void Start()
    {
        keypadOB.SetActive(false);
    }

    public void Number(int number)
    {
        textOB.text += number.ToString();
        button.Play();
    }

    public void Execute()
    {
        if (textOB.text == answer)
        {
            correct.Play();
            textOB.text = "Right";
        }
        else
        {
            wrong.Play();
            textOB.text = "Wrong";
        }
    }

    public void Clear()
    {
        textOB.text = "";
        button.Play();
    }

    public void Exit()
    {
        keypadOB.SetActive(false);
    }

    public void Update()
    {
        if (textOB.text == "Right" && animate)
        {
            ANI.SetBool("animate", true);
            Debug.Log("it's open");
        }
 
    }

}
