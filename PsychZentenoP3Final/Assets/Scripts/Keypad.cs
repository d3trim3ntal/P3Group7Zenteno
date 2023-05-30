using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    string Code = "9743";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public TextMeshProUGUI UiText = null;
    public GameObject doorOpened;
    public GameObject doorClosed;
    public GameObject keypadCanvas;

    void Start()
    {
        doorOpened.gameObject.SetActive(false);
        doorClosed.gameObject.SetActive(true);
        keypadCanvas.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            keypadCanvas.gameObject.SetActive(true);
        }
    }

    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;
    }

    public void Enter()
    {
        if (Nr == Code)
        {
            keypadCanvas.gameObject.SetActive(false);
            doorClosed.gameObject.SetActive(false);
            doorOpened.gameObject.SetActive(true);
        }
    }

    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }
}
