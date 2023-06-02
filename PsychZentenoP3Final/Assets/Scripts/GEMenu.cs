using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GEMenu : MonoBehaviour
{
    public GameObject MemoriesPnl;

    
    public void RestartBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void TruthBtn()
    {
        MemoriesPnl.gameObject.SetActive(true);
    }

    public void ReturnBtn()
    {
        MemoriesPnl.gameObject.SetActive(false);
    }
}
