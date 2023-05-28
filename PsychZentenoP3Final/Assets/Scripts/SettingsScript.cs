using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
	public TMPro.TMP_Dropdown GraphicsDrop, ResoDrop;

	void Start()
	{
		if(PlayerPrefs.GetInt("settingsSaved", 0) == 0)
		{
			PlayerPrefs.SetInt("graphics", 0);
			PlayerPrefs.SetInt("resolution", 0);
		}
		//Graphics
		if(PlayerPrefs.GetInt("graphics", 2) == 2)
		{
			GraphicsDrop.value = 0;
			QualitySettings.SetQualityLevel(0);
		}
		if(PlayerPrefs.GetInt("graphics", 1) == 1)
		{
			GraphicsDrop.value = 1;
			QualitySettings.SetQualityLevel(1);
		}
		if(PlayerPrefs.GetInt("graphics", 0) == 0)
		{
			GraphicsDrop.value = 2;
			QualitySettings.SetQualityLevel(2);
		}
		//Resolution
		if(PlayerPrefs.GetInt("resolution", 2) == 2)
		{
			ResoDrop.value = 0;
			Screen.SetResolution(854, 480, true);
		}
		if(PlayerPrefs.GetInt("resolution", 1) == 1)
		{
			ResoDrop.value = 1;
			Screen.SetResolution(1280, 720, true);
		}
		if(PlayerPrefs.GetInt("resolution", 0) == 0)
		{
			ResoDrop.value = 2;
			Screen.SetResolution(1920, 1080, true);
		}
	}

	public void setGraphics()
	{
		if(GraphicsDrop.value == 0)
		{
		PlayerPrefs.SetInt("graphics", 2);
		PlayerPrefs.Save();
		QualitySettings.SetQualityLevel(0);
		}
		if(GraphicsDrop.value == 1)
		{
		PlayerPrefs.SetInt("graphics", 1);
		PlayerPrefs.Save();
		QualitySettings.SetQualityLevel(1);
		}
		if(GraphicsDrop.value == 0)
		{
		PlayerPrefs.SetInt("graphics", 0);
		PlayerPrefs.Save();
		QualitySettings.SetQualityLevel(2);
		}
	}

	public void setResolution()
	{
		if(ResoDrop.value == 0)
		{
			PlayerPrefs.SetInt("resolution", 2);
			PlayerPrefs.Save();
			Screen.SetResolution(854, 480, true);
			Debug.Log("480p set");
		}
		if(ResoDrop.value == 1)
		{
			PlayerPrefs.SetInt("resolution", 1);
			PlayerPrefs.Save();
			Screen.SetResolution(1280, 720, true);
			Debug.Log("720p set");
		}
		if(ResoDrop.value == 2)
		{
			PlayerPrefs.SetInt("resolution", 0);
			PlayerPrefs.Save();
			Screen.SetResolution(1920, 1080, true);
			Debug.Log("1080p set");
		}
	}

	public void saveSettings()
	{
		PlayerPrefs.SetInt("settingSaved", 1);
		PlayerPrefs.Save();
	}
}
