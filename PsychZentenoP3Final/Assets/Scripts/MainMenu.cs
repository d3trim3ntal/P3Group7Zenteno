using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsPnl;
    public GameObject SettingsPnl;
    public GameObject KeysIndexPnl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContinueBtn()
    {
        SceneManager.LoadScene("CuriosityKilledtheCat");
    }

    public void ReturnButton()
    {
        OptionsPnl.gameObject.SetActive(false);
    }

    public void SettingsReturnButton()
    {
        SettingsPnl.gameObject.SetActive(false);
    }

    public void KeysIndexReturnButton()
    {
        KeysIndexPnl.gameObject.SetActive(false);
    }

    public void OptionsButton()
    {
        OptionsPnl.gameObject.SetActive(true);
    }

    public void SettingsButton()
    {
        SettingsPnl.gameObject.SetActive(true);
    }

    public void KeysIndexButton()
    {
        KeysIndexPnl.gameObject.SetActive(true);
    }
}
