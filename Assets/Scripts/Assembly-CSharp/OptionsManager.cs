using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200001B RID: 27
public class OptionsManager : MonoBehaviour
{
	// Token: 0x06000061 RID: 97 RVA: 0x000037B4 File Offset: 0x00001BB4
	private void Start()
	{
		if (PlayerPrefs.HasKey("OptionsSet"))
		{
			slider.value = PlayerPrefs.GetFloat("MouseSensitivity");
			SmoothTurn.isOn = (PlayerPrefs.GetInt("SmoothTurn") == 1);
            ImmersiveNotebooks.isOn = (PlayerPrefs.GetInt("ImmersiveNotebook") == 1);
            BSODLazer.isOn = (PlayerPrefs.GetInt("BSODLazer") == 1);
        }
		else
		{
			PlayerPrefs.SetInt("OptionsSet", 1);
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003850 File Offset: 0x00001C50
	private void Update()
	{
		PlayerPrefs.SetFloat("MouseSensitivity", slider.value);
		if (SmoothTurn.isOn)
		{
			PlayerPrefs.SetInt("SmoothTurn", 1);
		}
		else
		{
			PlayerPrefs.SetInt("SmoothTurn", 0);
		}
        if (BSODLazer.isOn)
        {
            PlayerPrefs.SetInt("BSODLazer", 1);
        }
        else
        {
            PlayerPrefs.SetInt("BSODLazer", 0);
        }
		if (ImmersiveNotebooks.isOn)
		{
			PlayerPrefs.SetInt("ImmersiveNotebook", 1);
        }
		else
		{
			PlayerPrefs.SetInt("ImmersiveNotebook", 0);
        }


    }

    // Token: 0x0400006F RID: 111
    public Slider slider;

	public Toggle ImmersiveNotebooks;

	public Toggle SmoothTurn;

	public Toggle BSODLazer;
}
